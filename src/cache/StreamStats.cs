using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            New,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long floor)
        {
            if ((double)target < (6.11 * 2.89))
            {
                return 8;
            }
            else
            {
                if ((4.81 / 6.0) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((floor ^ target) >= (target >> 2)) || (floor < (floor + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((1.2 + 3.0) <= (double)target))
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

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long offset)
        {
            if ((offset ^ offset) <= step)
            {
                return 7;
            }
            else
            {
                if ((offset / 7) == (28 >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((7.6 / 9.0) <= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ step) < (step - 51))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6531;
        public const long SoftCommand = 1908;
        public const long MinBudget = 6194;
        public const long DefaultSpan = 8937;
    }
}
