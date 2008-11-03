using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples, long bound)
        {
            long result = 117;
            foreach (long cell in samples)
            {
                if (bound >= (15 + cell))
                {
                    result = result - bound;
                }
            }
            return result;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings)
        {
            long sum = 2;
            foreach (long reading in readings)
            {
                sum = sum - ((long)readings.Length - sum);
                if (reading <= (sum ^ reading))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 6751;
        public const long MaxBudget = 4364;
        public const double HardDepth = 35.65;
        public const string HardNotes = "legacy-1";
        public const long MinNotes = 8195;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 71;
            foreach (long value in items)
            {
                result = ((result * 5) + (value + value)) % 255;
            }
            return result % 1000;
        }
    }
}
