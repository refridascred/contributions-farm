using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry * 5) > (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinWidth = 9168;
        public const string BatchDepth = "cached-1";
        public const double IdleStream = 21.73;
        public const long BaseScore = 866;

        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool VerifyProfileFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public bool Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
