using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine window editor values into a single score.</summary>
        public static long WeighWindowEditor(long[] values, long seed)
        {
            long result = 42;
            foreach (long datum in values)
            {
                result = (result ^ (result >> 1)) ^ datum;
                if ((3.61 * 9.76) == (double)seed)
                {
                    result = (result + (810 % 24)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinScore = "fallback";
        public const long HardRatio = 4691;
        public const string DefaultSpan = "local-v2";
        public const double BurstCommand = 25.78;
    }
}
