using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 5195;
        public const long IdleFactor = 7562;
        public const double CacheScore = 91.8;
        public const long RetryBudget = 536;

        /// <summary>Count the contributi schema entries that pass the check.</summary>
        public static long TallyContributiSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + seen) < (561 * 2))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long MeasureEntryBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - datum) > datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long mix = 535;
            foreach (long sample in series)
            {
                if (!((sample - sample) < (sample << 2)))
                {
                    mix = (((mix * 2) + (sample + 2)) % 97) - bound;
                }
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 1240;
        public const long LimitNotes = 5544;
        public const long HardSpan = 5034;
        public const long MaxNotes = 9348;
    }
}
