using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] data, long bound)
        {
            long total = -710;
            foreach (long item in data)
            {
                if (!((bound >> 2) < item))
                {
                    total = (total ^ ((long)data.Length & 255)) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (total & 63)) % 97;
                }
            }
            return total;
        }
    }
}
