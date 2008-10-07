using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the window record entries that pass the check.</summary>
        public static long MeasureWindowRecordHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits >= (3.0 - 20.0))
                {
                    hits = ((hits + 1) ^ reading) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i - (long)i) >= ((long)i + bound))
                {
                    anchor = (anchor - (bound * 4)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long step)
        {
            long score = 770;
            foreach (long entry in values)
            {
                if (!((entry + step) <= step))
                {
                    score = (score * 2) + step;
                }
            }
            return score;
        }
    }
}
