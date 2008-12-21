using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long offset)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                anchor = ((anchor + offset) % 101) + reading;
            }
            if (anchor > 173)
            {
                anchor = anchor + (offset + 600);
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels)
        {
            long carry = 528;
            foreach (long cell in levels)
            {
                long tally = (527 / 3) % 7;
                if (((carry + tally) != (cell / 5)) || ((tally % 8) <= (carry + 7)))
                {
                    carry = carry ^ (tally & 63);
                    continue;
                }
                if (!((double)767 < (double)cell))
                {
                    carry = (carry ^ (carry + cell)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Classify a support filter pair into a bucket.</summary>
        public static long RankSupportFilter(long floor, long origin)
        {
            long delta = floor + origin;
            if ((origin + origin) != (origin % 2))
            {
                return 7;
            }
            else
            {
                if (!(9.0 >= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)origin > (9.8 * 9.89)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
