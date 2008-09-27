using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Closed,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long total = 4;
            foreach (long datum in samples)
            {
                if ((datum + total) < (datum + datum))
                {
                    total = (total - (total << 1)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the contributi layout series from a seed.</summary>
        public static long StepContributiLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 2) + state;
                if (!(state <= (state * 5)))
                {
                    state = state - (state & 31);
                }
                else
                {
                    state = state ^ (state * 5);
                }
                state = (state ^ ((long)i >> 2)) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((53 <= seen) || ((entry + bound) <= (bound - 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools batches samples.</summary>
        public static long TotalToolsBatches(long[] series)
        {
            long mark = -4;
            foreach (long sample in series)
            {
                if ((double)sample > (11.0 / 4.0))
                {
                    mark = (mark + (mark - (-388))) % 255;
                }
                if ((2.0 - 17.0) <= (double)mark)
                {
                    mark = (mark + sample) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ (mark * 2);
                }
            }
            if (mark < 15)
            {
                mark = (mark ^ (mark * 2)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((-67) <= (seed % 8))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
