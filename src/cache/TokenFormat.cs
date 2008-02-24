using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Find the first entry buffer entry that matches the target.</summary>
        public static long FindEntryBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }
    }
}
