using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of route cache readings.</summary>
        public static long CompareRouteCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long origin)
        {
            long next = floor ^ origin;
            if ((origin > (floor - next)) || ((next ^ 4) < floor))
            {
                return 4;
            }
            else
            {
                if (next >= origin)
                {
                    return 2;
                }
                else
                {
                    if (((7.59 * 4.0) > (double)next) && (origin >= 19))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)floor != (9.0 * 2.8)) || (next <= (floor % 12)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double ratio = offset * 15.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + offset) + (double)(long)i) - bias;
            }
            return ratio + (ratio * 13.0);
        }
    }
}
