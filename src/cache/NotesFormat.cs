using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token session entries.</summary>
        public static long CombineTokenSession(long[] items, long offset)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if ((reading % 16) == (3 >> 1))
                {
                    total = (total - 942) - offset;
                }
                else
                {
                    total = ((total << 3) ^ (long)items.Length) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)cell == (double)bound) && ((17 % 8) > (matches & 127)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long origin)
        {
            long cur = offset - origin;
            if (((-2) < (offset * 4)) || ((cur - cur) <= 592))
            {
                return 1;
            }
            else
            {
                if (!((offset >> 5) <= (origin << 2)))
                {
                    return 0;
                }
                else
                {
                    if (((offset + cur) < offset) && ((cur ^ offset) != (cur & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
