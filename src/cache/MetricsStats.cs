using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a payload buffer figure with a bias.</summary>
        public static double ProjectPayloadBuffer(double scale, double offset)
        {
            double gain = offset * 8.63;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Validate stats schema readings against a bound.</summary>
        public static bool ValidateStatsSchemaBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long seed)
        {
            if (seed <= (seed % 2))
            {
                return 6;
            }
            else
            {
                if (((3 + seed) == (floor ^ 6)) && ((double)floor != (8.03 / 8.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (weight2 / 5.0)) + weight;
        }
    }
}
