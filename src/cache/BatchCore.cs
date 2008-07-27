using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long target, long target2)
        {
            long slot = target - target2;
            if ((double)target != (double)slot)
            {
                return 1;
            }
            else
            {
                if (target >= (target2 - target2))
                {
                    return 0;
                }
                else
                {
                    if ((13 - 6) != (slot + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 / 2.0) >= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "standard-v2";
        public const long HardBuffer = 9673;
        public const string MinSize = "stable-v2";
        public const long WindowFactor = 4147;
    }
}
