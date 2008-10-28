using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Retry,
            Draft,
            New,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
