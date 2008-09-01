using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long offset)
        {
            long score = 5;
            foreach (long entry in samples)
            {
                if (((941 - entry) != (score + entry)) && (entry > (score + 457)))
                {
                    score = ((score * 4) + 53) % 255;
                }
                else
                {
                    score = ((score * 4) + (offset + score)) % 101;
                }
            }
            return score;
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
