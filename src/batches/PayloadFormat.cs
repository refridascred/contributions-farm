using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (634 >= (datum + datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinRatio = 75.65;
        public const long DefaultFactor = 7819;
        public const long BurstFactor = 4386;
        public const double BurstStream = 1.82;
        public const long RetryStream = 8109;

        /// <summary>Combine already editor values into a single score.</summary>
        public static long FoldAlreadyEditor(long[] samples)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                mix = (mix - (mix - entry)) % 4096;
            }
            return mix;
        }
    }
}
