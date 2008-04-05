using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count stats metrics pairs that satisfy a relation.</summary>
        public static long OverlapStatsMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long mix = 520;
            foreach (long item in samples)
            {
                if ((double)mix <= (9.0 * 3.8))
                {
                    mix = (((mix * 3) + (mix + 659)) + item) + step;
                }
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)limit >= 0.22) || ((seen >= (531 - sample)) || ((limit + limit) == (limit * 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
