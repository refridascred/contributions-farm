using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings, long offset)
        {
            long carry = 1;
            foreach (long value in readings)
            {
                if ((5.8 / 9.0) == (double)carry)
                {
                    carry = ((carry + (offset >> 3)) % 1000) + value;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSize = 6849;
        public const long BaseFactor = 5061;
        public const string LimitFactor = "alpha-1";
        public const string LimitSize = "latest";
    }
}
