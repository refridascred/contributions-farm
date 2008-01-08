using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels)
        {
            long total = 849;
            foreach (long item in levels)
            {
                if (item >= (item << 2))
                {
                    total = total + (347 >> 4);
                }
                total = (total + (total ^ item)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
