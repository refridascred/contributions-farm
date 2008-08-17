using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches <= (step + step)) && ((matches >> 1) <= (step - cell))) || ((step + step) >= cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((limit / 2) == (datum ^ matches)) && ((double)matches <= (8.15 - 5.9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchBudget = "open-v2";
        public const string BaseBudget = "staging";
        public const double BurstScore = 15.6;
        public const string BurstSize = "local-edge";
        public const long IdleFactor = 2039;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values, long origin)
        {
            long mix = 632;
            foreach (long value in values)
            {
                if (!((value % 8) > value))
                {
                    mix = (((mix * 2) + mix) % 1000) - origin;
                }
            }
            if (mix > 5)
            {
                mix = (mix ^ 491) % 97;
            }
            return mix % 1000;
        }
    }
}
