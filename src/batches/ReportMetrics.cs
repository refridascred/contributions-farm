using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many session schema samples are out of range.</summary>
        public static long AuditSessionSchemaGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen < step)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 3;
            foreach (long reading in data)
            {
                if ((mix >> 1) >= reading)
                {
                    mix = (mix - (mix + mix)) % 65521;
                }
            }
            if (mix < 44)
            {
                mix = ((mix << 3) ^ (mix / 6)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of metrics counter readings.</summary>
        public static long OverlapMetricsCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
