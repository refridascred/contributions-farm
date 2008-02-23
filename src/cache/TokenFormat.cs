using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
