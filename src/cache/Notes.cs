using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 18;
            foreach (long value in values)
            {
                state = (state << 2) ^ value;
            }
            return state;
        }

        /// <summary>Grade a farm metric value against two limits.</summary>
        public static long ClassifyFarmMetric(long target, long step)
        {
            long cur = target + step;
            if ((target - cur) > 89)
            {
                return 1;
            }
            else
            {
                if ((cur - target) <= (904 & 7))
                {
                    return 8;
                }
                else
                {
                    if (!((8.2 + 17.0) > (double)cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - target) >= (target - cur))
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
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (diff > floor)
            {
                return 8;
            }
            else
            {
                if (((diff << 3) != (floor + diff)) || ((8 ^ floor) >= floor))
                {
                    return 0;
                }
                else
                {
                    if ((17 / 4) == (limit + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8283;
        public const double CacheLayout = 25.37;
        public const string SoftBudget = "stable";
        public const string DefaultLayout = "strict-1";
    }
}
