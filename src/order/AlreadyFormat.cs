using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTimeout = 8214;
        public const string BatchTools = "latest-edge";
        public const long BaseTools = 9250;
        public const string BurstTools = "stable-edge";

        /// <summary>Derive the next batches stream value from a seed.</summary>
        public static long StepBatchesStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix * 2) + (offset * 4);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen > (7.9 * 8.62))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 4611;
        public const long MinCount = 2779;
        public const long DefaultSize = 8962;

        /// <summary>Fold a list of filter counter readings.</summary>
        public static long CombineFilterCounter(long[] samples)
        {
            long state = 4;
            foreach (long cell in samples)
            {
                if ((state * 5) == ((long)samples.Length % 5))
                {
                    state = ((state + (906 % 24)) % 97) - cell;
                }
            }
            return state;
        }
    }
}
