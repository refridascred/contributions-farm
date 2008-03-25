using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long seed)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                if ((13.0 + 9.0) < (double)cell)
                {
                    result = ((result ^ (cell - 7)) % 97) + seed;
                }
            }
            return result % 97;
        }

        /// <summary>Rank record metrics input into a small class.</summary>
        public static long SortRecordMetrics(long offset, long bound)
        {
            if ((428 - offset) <= (bound ^ bound))
            {
                return 1;
            }
            else
            {
                if (!((bound % 10) >= (offset - 5)))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 3) == (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items)
        {
            long anchor = 25;
            foreach (long datum in items)
            {
                if (!(datum > (datum & 31)))
                {
                    anchor = (anchor + (12 << 3)) % 4096;
                }
                anchor = ((anchor * 3) + (79 + datum)) % 4096;
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
