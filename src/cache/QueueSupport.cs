using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstWidth = "standard";
        public const string MinRatio = "legacy-1";
        public const double IdleRatio = 38.64;
        public const long DefaultScore = 276;
        public const long DefaultMetric = 3939;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples, long step)
        {
            long result = 7;
            foreach (long reading in samples)
            {
                result = (result ^ (18 ^ reading)) - step;
                result = (result ^ reading) % 65521;
            }
            return result % 65521;
        }
    }
}
