using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (bound - 87)) % 97;
                state = ((state << 3) ^ 19) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every counter already entry stays within the limit.</summary>
        public static bool CheckCounterAlreadyLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry & 127) <= (entry << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitBudget = 92.52;
        public const double WindowCache = 72.9;
        public const long StepSpan = 5571;
        public const long DefaultSpan = 2965;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long origin)
        {
            long acc = 417;
            foreach (long value in data)
            {
                long prev = origin;
                if ((double)prev < 0.6)
                {
                    prev = (prev + (origin + 86)) % 97;
                    acc = ((acc * 3) + (origin + prev)) % 1000;
                }
                if (value <= acc)
                {
                    acc = (acc - (acc + origin)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((1.9 - 5.5) == (double)target)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
