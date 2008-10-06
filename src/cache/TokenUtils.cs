using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next buffer contributi value from a seed.</summary>
        public static long StepBufferContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (((sum * 4) + target) % 101) - (long)i2;
                }
                sum = (sum + (sum + target)) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
