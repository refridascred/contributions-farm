using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 9411;
        public const long SoftScore = 8080;
        public const double SoftAccount = 87.49;
        public const double WindowInterval = 79.46;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxRatio = 13.79;
        public const double CacheLevel = 97.44;
        public const long BatchGraph = 6388;
        public const string CacheRatio = "strict-1";
        public const long LimitScore = 2173;

        /// <summary>Audit buffer report readings against a rule.</summary>
        public static long CountBufferReportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((76 > (sample >> 2)) && ((tally ^ 6) > sample)) && ((0.4 + 3.0) == (double)sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
