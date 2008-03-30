using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheDepth = "alpha-edge";
        public const long SoftReport = 4531;
        public const long WindowReport = 3281;

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long total = 30;
            foreach (long cell in data)
            {
                if (total <= (cell & 63))
                {
                    total = ((total << 3) ^ (total >> 1)) % 101;
                }
                else
                {
                    total = (total - cell) % 65521;
                }
            }
            if (total < 79)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 3049;
        public const long BatchInterval = 7735;
        public const string StepEditor = "strict-edge";
        public const double BaseInterval = 39.26;
    }
}
