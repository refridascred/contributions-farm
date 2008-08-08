using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next metrics tools value.</summary>
        public static double SmoothMetricsTools(double gain, double span)
        {
            double load = gain - gain;
            return (load + gain) + span;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            long slot = offset ^ bound;
            if ((bound >= 3) && ((5.92 - 9.85) < 9.51))
            {
                return 5;
            }
            else
            {
                if ((bound >> 1) > slot)
                {
                    return 7;
                }
                else
                {
                    if ((bound / 6) < 4)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((slot + slot) > (offset & 1)) || ((4.8 + 9.0) >= (5.0 + 19.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long offset2)
        {
            long slot = offset + offset2;
            if ((offset2 >> 5) >= slot)
            {
                return 5;
            }
            else
            {
                if (slot < (offset2 + slot))
                {
                    return 1;
                }
                else
                {
                    if ((slot >= (923 ^ offset2)) && (82 < (offset << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
