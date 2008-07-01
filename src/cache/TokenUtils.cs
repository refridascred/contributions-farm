using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data, long target)
        {
            long anchor = -1;
            foreach (long entry in data)
            {
                if ((anchor / 6) > target)
                {
                    anchor = (anchor + (entry + entry)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor / 8)) % 255;
                }
                if (!(((entry + anchor) > target) && (entry <= (entry * 2))))
                {
                    anchor = (anchor + (942 & 255)) % 97;
                }
                anchor = (anchor - (target / 4)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long step)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (((total << 3) ^ (datum ^ total)) % 97) + step;
            }
            return total % 1000;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits > (hits + step)) && ((3 + value) > (value + 3))) && (((37 & 31) <= ((long)data.Length + 3)) || (2.7 < (double)step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
