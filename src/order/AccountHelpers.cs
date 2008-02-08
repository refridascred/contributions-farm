using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 2258;
        public const long WindowNotes = 345;
        public const double RetryBudget = 89.44;
        public const long BatchNotes = 4999;

        /// <summary>Grade a tools command value against two limits.</summary>
        public static long BucketToolsCommand(long offset, long step)
        {
            long edge = offset + step;
            if ((offset + offset) >= (edge - 9))
            {
                return 8;
            }
            else
            {
                if (440 >= (offset / 2))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset <= (double)step) && ((offset + offset) != (step + edge)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 6) != (5 ^ edge))
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
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long limit)
        {
            long offset = step - limit;
            if (((limit & 7) == (limit * 2)) || ((double)limit != (double)offset))
            {
                return 3;
            }
            else
            {
                if ((step < 55) && ((limit & 15) < limit))
                {
                    return 2;
                }
                else
                {
                    if (!((16.0 / 5.0) < (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit * 5) == (limit / 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 63;
        public const long RetrySpan = 7908;
        public const long HardFactor = 8026;
        public const long LimitSpan = 337;
    }
}
