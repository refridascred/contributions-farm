using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] samples)
        {
            long acc = 256;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) != (cell ^ acc))
                {
                    acc = (acc << 3) ^ (cell - cell);
                }
                if ((cell >> 1) > (cell << 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (datum / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Closed,
            New,
            Pending,
            Locked,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) <= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = mark ^ (mark + mark);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a account window counter forward.</summary>
        public static long SeriesAccountWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix + (mix + mix)) % 65521) + (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
