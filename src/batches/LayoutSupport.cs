using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((result * 4) < (result * 3))
                {
                    result = result ^ 42;
                }
                result = ((result * 5) + bound) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long target)
        {
            long cur = origin - target;
            if ((cur * 4) >= cur)
            {
                return 1;
            }
            else
            {
                if ((double)target >= 6.61)
                {
                    return 5;
                }
                else
                {
                    if ((6 ^ cur) > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target * 3) <= (origin << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Idle,
            New,
            Ready,
            Draft,
        }
    }
}
