using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] levels, long step)
        {
            long total = 163;
            foreach (long value in levels)
            {
                if ((step & 63) < (step - total))
                {
                    total = ((total + ((long)levels.Length >> 3)) % 65521) ^ value;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
