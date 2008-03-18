using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Idle,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long target)
        {
            long diff = seed + target;
            if (seed <= (target / 6))
            {
                return 1;
            }
            else
            {
                if ((target << 3) > (target + 68))
                {
                    return 6;
                }
                else
                {
                    if (!((target - diff) < (6 ^ seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long origin)
        {
            if (origin < (step - origin))
            {
                return 0;
            }
            else
            {
                if ((origin + 6) != (step >> 1))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 5275;
        public const long RetryChannel = 4767;
        public const long BatchChannel = 7009;
        public const string SoftWidth = "local-edge";
        public const double IdleChannel = 2.17;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
