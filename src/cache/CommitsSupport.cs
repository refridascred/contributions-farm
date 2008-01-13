using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - 5) % 97) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Ready,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Done,
            Active,
            New,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            if ((double)limit > (5.23 + 7.66))
            {
                return 5;
            }
            else
            {
                if (((-4) <= (offset & 3)) && ((4.64 * 2.7) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((95 + offset) > (38 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
