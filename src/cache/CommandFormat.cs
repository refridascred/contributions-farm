using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "legacy-edge";
        public const string SoftScore = "open-v2";
        public const long LimitSpan = 4908;
        public const long CacheFarm = 8079;
        public const double MinCount = 91.43;

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a cache session counter forward.</summary>
        public static long SeriesCacheSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum ^ sum) % 4096;
                if (((sum + sum) != (sum / 2)) && ((sum + bound) >= (bound << 1)))
                {
                    sum = (sum ^ (sum - sum)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
