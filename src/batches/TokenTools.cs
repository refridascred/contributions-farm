using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values, long offset)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                mix = (mix - (595 % 60)) % 4096;
                if (((offset + datum) != (datum - mix)) && (datum > offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long offset)
        {
            long gap = floor - offset;
            if ((double)floor == (2.0 + 18.0))
            {
                return 7;
            }
            else
            {
                if ((gap ^ gap) >= gap)
                {
                    return 4;
                }
                else
                {
                    if ((floor << 3) > gap)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen < (seen / 7))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
