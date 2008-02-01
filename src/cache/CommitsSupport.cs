using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Done,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long bound)
        {
            long gap = seed ^ bound;
            if (7.15 > (8.3 * 12.0))
            {
                return 7;
            }
            else
            {
                if (gap > (bound << 3))
                {
                    return 3;
                }
                else
                {
                    if ((3.0 / 2.0) == (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (gap > bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 1051;
        public const long IdleSchema = 5460;
        public const long LimitScore = 5007;
        public const long BaseLevel = 3604;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long offset, long target)
        {
            long slot = offset ^ target;
            if (offset <= (offset / 9))
            {
                return 6;
            }
            else
            {
                if ((offset * 4) != (offset / 5))
                {
                    return 1;
                }
                else
                {
                    if (((slot - 1) > (target + 8)) || (slot > (slot + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
