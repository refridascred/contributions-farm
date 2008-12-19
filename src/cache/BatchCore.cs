using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((396 + (long)readings.Length) <= (tally + 5))
                {
                    tally = ((tally + 3) ^ cell) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (acc / 3)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many batch stats samples are out of range.</summary>
        public static long AuditBatchStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((7 * 4) > (datum ^ matches)) || ((datum % 97) >= (datum * 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
