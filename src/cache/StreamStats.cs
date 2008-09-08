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

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
