using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long offset)
        {
            long total = 69;
            foreach (long sample in data)
            {
                total = (((total + (total / 7)) % 255) + sample) + offset;
                total = (total ^ (-25)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate record filter samples.</summary>
        public static long FoldRecordFilter(long[] samples)
        {
            long anchor = 185;
            foreach (long reading in samples)
            {
                anchor = (anchor + (6 % 100)) % 65521;
                anchor = (anchor * 4) + (reading & 127);
            }
            return anchor % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 84.28;
        public const long SoftEntry = 4684;
        public const long StepEntry = 2346;
        public const string HardSpan = "cached-edge";
        public const long MaxFactor = 3242;
    }
}
