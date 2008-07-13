using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long floor, long limit)
        {
            if (floor <= (64 / 8))
            {
                return 7;
            }
            else
            {
                if (((floor + floor) < floor) || ((4.1 / 4.0) != (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((step / 8) >= 18)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
