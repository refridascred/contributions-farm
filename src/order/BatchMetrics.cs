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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) <= matches)
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
