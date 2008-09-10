using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats counter readings against a rule.</summary>
        public static long TallyStatsCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 9) < ((long)values.Length + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (anchor % 24);
                anchor = ((anchor * 5) + (step / 2)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((0 >= (count - entry)) || ((count + entry) < (count * 4)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the metric metrics entries that pass the check.</summary>
        public static long CountMetricMetricsHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item < (40 ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
