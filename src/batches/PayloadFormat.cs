using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "stable-1";
        public const string DefaultRatio = "stable-v2";
        public const double IdleInterval = 58.62;
        public const long DefaultScore = 486;
        public const long HardSchema = 5480;

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long limit)
        {
            if ((limit + limit) != (752 << 3))
            {
                return 3;
            }
            else
            {
                if (!((double)limit == (2.35 + 8.0)))
                {
                    return 0;
                }
                else
                {
                    if ((655 ^ target) >= 6)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 2) > (limit / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
