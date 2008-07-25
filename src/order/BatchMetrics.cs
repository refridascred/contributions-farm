using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every account command entry stays within the limit.</summary>
        public static bool VerifyAccountCommandBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            long gap = seed + floor;
            if (((755 >> 2) == (seed ^ gap)) && ((seed ^ gap) == (215 % 64)))
            {
                return 1;
            }
            else
            {
                if (((double)seed < (double)gap) || ((0 / 4) >= (seed % 24)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 2627;
        public const long WindowDepth = 4841;
        public const long LimitRecord = 864;
        public const string MaxRecord = "primary-edge";
        public const string RetryRecord = "local-edge";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long seed, long floor)
        {
            long slot = seed ^ floor;
            if (floor >= (floor + floor))
            {
                return 6;
            }
            else
            {
                if (floor < slot)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitLevel = 2250;
        public const long WindowWidth = 8635;
        public const string RetryBuffer = "legacy-v2";
        public const long LimitBudget = 9203;
        public const string DefaultBuffer = "strict-1";
    }
}
