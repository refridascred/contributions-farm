using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long origin2)
        {
            if ((origin + origin2) >= (origin2 ^ origin2))
            {
                return 4;
            }
            else
            {
                if ((origin / 4) <= origin2)
                {
                    return 7;
                }
                else
                {
                    if (((origin2 + origin) <= origin) || ((origin2 ^ origin2) <= (origin / 7)))
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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (22 >= (entry * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxSize = "fallback-v2";
        public const double BaseSize = 82.53;
        public const long DefaultSize = 1489;
    }
}
