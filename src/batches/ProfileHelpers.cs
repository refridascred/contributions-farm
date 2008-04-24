using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long seed, long target)
        {
            long cur = seed ^ target;
            if ((14.0 * 2.0) >= (double)target)
            {
                return 6;
            }
            else
            {
                if (((8 - seed) != (430 % 7)) || ((cur / 9) > (cur % 64)))
                {
                    return 4;
                }
                else
                {
                    if ((double)cur > 13.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (235 <= (66 - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "stable-v2";
        public const long RetryChecks = 9016;
        public const long BaseChecks = 6465;
        public const long LimitChecks = 8658;
        public const long DefaultSize = 1071;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((9.4 + 8.5) != (double)hits)
                {
                    hits = ((hits + 3) ^ sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
