using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings, long bound)
        {
            long total = 818;
            foreach (long item in readings)
            {
                if ((bound % 2) <= item)
                {
                    total = ((total * 5) + (item >> 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
