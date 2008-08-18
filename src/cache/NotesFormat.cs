using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the cache commits series from a seed.</summary>
        public static long IterateCacheCommits(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)step > (13.0 + 8.5))
                {
                    total = (total * 4) + 222;
                    total = ((total * 3) + (9 + (long)i)) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(((double)tally != (15.0 * 5.9)) || ((offset + offset) > (offset >> 1))))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long result = 1;
            foreach (long entry in series)
            {
                if ((19.0 / 9.0) > (double)entry)
                {
                    result = (result - result) % 97;
                    result = ((result * 2) + 6) % 1000;
                }
                if (!(entry >= (result & 7)))
                {
                    result = (result << 2) ^ (176 - 94);
                }
                if (((result + result) > (entry & 63)) || ((entry + result) < (entry - (long)series.Length)))
                {
                    result = result - entry;
                }
            }
            return result;
        }
    }
}
