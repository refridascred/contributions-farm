using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((81 + entry) >= (seen - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Grade a entry profile value against two limits.</summary>
        public static long BucketEntryProfile(long seed, long step)
        {
            long lane = seed - step;
            if (((-228) % 100) != (step * 5))
            {
                return 0;
            }
            else
            {
                if ((lane * 5) > (-6))
                {
                    return 8;
                }
                else
                {
                    if ((lane + lane) >= (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long offset, long target)
        {
            if (((double)offset != (5.8 - 2.17)) || ((target + target) < 0))
            {
                return 7;
            }
            else
            {
                if ((9.23 - 9.0) <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target < (target + offset)) && ((20.0 / 9.0) != (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
