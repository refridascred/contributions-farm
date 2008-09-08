using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 95.95;
        public const long SoftFactor = 154;
        public const string SoftSession = "legacy-v2";
        public const long SoftDepth = 1799;
        public const long BatchSpan = 965;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Dropped,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long CombineNotesBatches(long[] levels)
        {
            long carry = 575;
            foreach (long datum in levels)
            {
                carry = (carry ^ carry) ^ datum;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long carry = 243;
            foreach (long sample in items)
            {
                if (((double)6 >= (double)carry) && ((sample << 3) <= (carry + sample)))
                {
                    carry = (carry ^ sample) % 97;
                }
                else
                {
                    carry = (carry ^ ((-447) % 100)) % 101;
                }
            }
            return carry % 65521;
        }
    }
}
