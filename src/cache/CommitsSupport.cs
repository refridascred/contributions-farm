using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank session batches input into a small class.</summary>
        public static long RankSessionBatches(long bound, long seed)
        {
            long cur = bound - seed;
            if (((seed % 2) == (cur + 341)) || (((-5) - 89) < (seed - cur)))
            {
                return 0;
            }
            else
            {
                if (cur > bound)
                {
                    return 7;
                }
                else
                {
                    if (bound <= cur)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((cur >> 2) == ((-673) + cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double gain = scale - scale;
            if (gain < scale)
            {
                gain = (gain + gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!(seen <= (seen >> 5)))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
