using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record route entries that pass the check.</summary>
        public static long CountRecordRouteGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value << 3) != (hits & 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
