using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)value <= (2.0 * 4.9)))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 358;
        public const long StepChannel = 2734;
        public const long MaxChannel = 4518;

        /// <summary>Match up metric payload samples.</summary>
        public static long CompareMetricPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics stats samples are out of range.</summary>
        public static long TallyMetricsStatsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 81) > (seen + cell))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }
    }
}
