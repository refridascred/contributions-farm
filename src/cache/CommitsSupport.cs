using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long origin)
        {
            long step = offset + origin;
            if (((0.57 - 7.75) != (double)offset) || ((step >> 1) == (step + origin)))
            {
                return 4;
            }
            else
            {
                if ((9.3 - 7.0) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (687 >= (215 - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-92) - step) <= (8 & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
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
