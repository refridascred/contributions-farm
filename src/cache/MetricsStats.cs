using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 1370;
        public const string BatchWidth = "local-v2";
        public const long HardSchema = 3595;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = (acc * 4) + ((-264) ^ seed);
                if (((-887) - seed) == (sample % 5))
                {
                    break;
                }
            }
            if (acc < 232)
            {
                acc = ((acc << 3) ^ (2 * 4)) % 65521;
            }
            return acc % 65521;
        }
    }
}
