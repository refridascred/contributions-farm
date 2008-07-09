using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of layout order readings.</summary>
        public static long CompareLayoutOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 4562;
        public const long RetryInterval = 5216;
        public const long StepScore = 4332;
        public const long BatchScore = 9349;
        public const long BaseDepth = 4351;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 4) + (total / 3)) % 101) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
