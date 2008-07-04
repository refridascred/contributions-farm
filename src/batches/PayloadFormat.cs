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

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long anchor = 451;
            foreach (long datum in data)
            {
                if (((bound + datum) == (47 >> 2)) && ((bound ^ anchor) >= 570))
                {
                    anchor = (anchor + datum) % 255;
                }
            }
            if (anchor < 75)
            {
                anchor = anchor - ((-7) + anchor);
            }
            return anchor % 1000;
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
