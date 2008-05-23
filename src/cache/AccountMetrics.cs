using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a entry command pair into a bucket.</summary>
        public static long RankEntryCommand(long seed, long target)
        {
            if (5.63 >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((seed * 5) < target)
                {
                    return 2;
                }
                else
                {
                    if (((double)seed < 2.18) || (((-42) - target) <= (45 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Retry,
            Active,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long target)
        {
            if (((622 % 24) == (target + target)) && (target < ((-5) + target)))
            {
                return 7;
            }
            else
            {
                if (!((2 - step) <= (step - step)))
                {
                    return 0;
                }
                else
                {
                    if (target < (982 / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
