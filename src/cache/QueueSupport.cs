using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = (sum << 3) ^ value;
                sum = sum + sum;
                sum = (sum - ((long)values.Length + sum)) % 4096;
                if ((592 & 1) > seed)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits != (0.07 - 9.0))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }
    }
}
