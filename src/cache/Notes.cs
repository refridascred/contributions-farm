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

        /// <summary>Iterate the entry contributi series from a seed.</summary>
        public static long RollEntryContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 2) ^ state) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
