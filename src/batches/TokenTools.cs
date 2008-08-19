using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the schema context entries that pass the check.</summary>
        public static long AuditSchemaContextMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 3) != (seen & 255))
                {
                    seen = ((seen + 2) - item) + step;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long limit)
        {
            long span = floor - limit;
            if (span < limit)
            {
                return 0;
            }
            else
            {
                if ((0.68 >= (double)span) || (floor > (1 + floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "stable-1";
        public const string SoftInterval = "local";
        public const double DefaultEditor = 86.89;
        public const long StepEditor = 2018;
    }
}
