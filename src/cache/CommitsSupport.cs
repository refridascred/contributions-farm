using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) == (hits - datum)) && ((double)datum != (16.0 * 11.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "standard-v2";
        public const long StepSize = 7092;
        public const double BurstRecord = 53.07;
        public const long LimitRecord = 4224;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Done,
            New,
            Locked,
            Pending,
        }

        /// <summary>Audit contributi metric readings against a rule.</summary>
        public static long MeasureContributiMetricHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((seen + (-999)) == (0 + step)) && ((double)step <= (1.0 - 17.0))) && ((80 + seen) >= (datum + 649)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Combine support batches values into a single score.</summary>
        public static long DigestSupportBatches(long[] items)
        {
            long total = 78;
            foreach (long entry in items)
            {
                total = ((total ^ (13 + 8)) % 1000) ^ entry;
            }
            return total;
        }
    }
}
