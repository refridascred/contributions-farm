using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (9.2 + 2.42))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the window tools entries that pass the check.</summary>
        public static long MeasureWindowToolsMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > sample)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8036;
        public const long BatchFormat = 1906;
        public const long HardFactor = 8279;
        public const double BaseFormat = 24.42;
        public const string LimitFormat = "local";
    }
}
