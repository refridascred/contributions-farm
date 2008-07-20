using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long step)
        {
            if (((target << 2) == (step / 7)) || ((step - target) > (target + target)))
            {
                return 2;
            }
            else
            {
                if ((2.4 * 8.9) >= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((step / 3) != (5 & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = carry - (limit / 4);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
