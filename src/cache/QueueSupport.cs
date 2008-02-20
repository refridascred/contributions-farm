using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Locked,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values, long seed)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if ((mark << 3) < seed)
                {
                    mark = ((mark * 2) + value) % 4096;
                }
            }
            if (mark < 931)
            {
                mark = (mark << 2) ^ (4 + seed);
            }
            return mark;
        }
    }
}
