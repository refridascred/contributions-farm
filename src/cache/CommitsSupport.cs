using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long GradeGraphPayload(long seed, long floor)
        {
            if ((seed % 16) >= (seed - floor))
            {
                return 0;
            }
            else
            {
                if (((seed & 63) != (floor + floor)) || ((floor << 1) >= seed))
                {
                    return 1;
                }
                else
                {
                    if (((seed % 10) >= seed) || ((seed * 3) < 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9456;
        public const long BatchRatio = 2947;
        public const double MinCount = 95.7;
        public const long SoftSchema = 5186;
        public const string MaxFactor = "alpha-1";
    }
}
