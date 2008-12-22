using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double scale, double offset)
        {
            double rate = scale;
            if (rate <= (rate * 15.0))
            {
                rate = (rate - rate) + offset;
            }
            return rate - 7.4;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double scale2 = (double)(1 * 4);
            return (scale2 + (offset + scale2)) + scale;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            if (((seed * 5) < (seed + seed2)) && ((22 + seed) <= (seed2 >> 5)))
            {
                return 8;
            }
            else
            {
                if ((6.0 * 13.0) <= (double)seed2)
                {
                    return 5;
                }
                else
                {
                    if (!((double)seed < (3.0 + 3.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (20 <= (seed2 & 255))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Pending,
        }
    }
}
