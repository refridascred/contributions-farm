using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                if ((anchor + anchor) < entry)
                {
                    anchor = (anchor + (entry / 8)) % 97;
                }
            }
            if (anchor < 663)
            {
                anchor = (anchor - (anchor & 127)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) >= (tally ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits == (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
