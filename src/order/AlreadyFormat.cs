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

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 4611;
        public const long MinCount = 2779;
        public const long DefaultSize = 8962;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Locked,
            Idle,
        }
    }
}
