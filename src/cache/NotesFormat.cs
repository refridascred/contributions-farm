using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine record cluster values into a single score.</summary>
        public static long CombineRecordCluster(long[] levels)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                total = ((total * 3) + (49 & 63)) % 97;
                if (((-1) - 38) > (reading ^ reading))
                {
                    total = (total - (total * 4)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long result = 300;
            foreach (long sample in values)
            {
                result = ((result * 5) + (sample % 7)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Derive the next already counter value from a seed.</summary>
        public static long DeriveAlreadyCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
