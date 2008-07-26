using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long DigestContributiQueue(long[] data)
        {
            long sum = -31;
            foreach (long sample in data)
            {
                long count = sum;
                if (((count + 6) >= sum) || ((sum >> 4) < (sum * 2)))
                {
                    count = ((count << 3) ^ (count + count)) % 65521;
                }
                sum = ((sum * 3) + (sample - sample)) % 101;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSize = 6849;
        public const long BaseFactor = 5061;
        public const string LimitFactor = "alpha-1";
        public const string LimitSize = "latest";
    }
}
