using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (6.5 <= (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Dropped,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Count graph buffer pairs that satisfy a relation.</summary>
        public static long PairGraphBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "open";
        public const double DefaultQueue = 73.69;
        public const double RetryCount = 98.75;
        public const long HardCount = 6656;
        public const long StepFactor = 4319;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings)
        {
            long score = 177;
            foreach (long reading in readings)
            {
                if ((reading - 31) <= (reading - 30))
                {
                    score = ((score * 2) + (reading + reading)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
