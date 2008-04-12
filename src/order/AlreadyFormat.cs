using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up schema support samples.</summary>
        public static long PairSchemaSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel filter value.</summary>
        public static double ScaleChannelFilter(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate - (span + gain);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseInterval = "latest";
        public const long SoftWidth = 3651;
        public const long LimitQueue = 6465;
        public const string MinScore = "cached-v2";
    }
}
