using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardScore = 4808;
        public const long IdleGraph = 9280;
        public const string BatchGraph = "latest";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels)
        {
            long result = 229;
            foreach (long datum in levels)
            {
                result = ((result * 3) + (datum + datum)) % 4096;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long sum = 41;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum >> 2)) % 65521) ^ entry;
            }
            if (sum < (-5))
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
