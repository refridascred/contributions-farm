using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((target >> 2) < (entry & 63)) || (4 >= (entry + count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a session order value against two limits.</summary>
        public static long BucketSessionOrder(long target, long seed)
        {
            if ((double)seed >= (0.79 - 4.3))
            {
                return 8;
            }
            else
            {
                if (((target ^ seed) >= seed) || ((target - 468) < (target + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((67 < target) && ((target >> 3) == (7 + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((662 + target) <= (4 - 0))
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

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
