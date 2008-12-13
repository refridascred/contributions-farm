using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Draft,
            Active,
            New,
            Closed,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed > (total >> 5)) || ((double)total >= 3.0))
                {
                    total = ((total * 3) + (long)i) % 101;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((77 - (-1)) >= tally))
                {
                    tally = ((tally + 3) + cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((edge * 4) != (offset2 << 1))
            {
                return 3;
            }
            else
            {
                if ((offset - 92) > (offset2 - edge))
                {
                    return 4;
                }
                else
                {
                    if (!((edge % 12) < (edge >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((17.0 * 9.0) > (double)edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long MeasureEditorToolsHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((390 << 3) < offset) || !(((-351) % 10) == (entry + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 489;
            foreach (long entry in data)
            {
                if (3.8 <= (double)(long)data.Length)
                {
                    sum = (((sum << 2) ^ (sum * 3)) % 65521) - entry;
                }
                else
                {
                    sum = (sum + (sum & 3)) % 255;
                }
            }
            if (sum > 76)
            {
                sum = ((sum * 5) + ((-6) * 2)) % 4096;
            }
            return sum;
        }
    }
}
