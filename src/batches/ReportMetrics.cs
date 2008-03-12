using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the cache already entries that pass the check.</summary>
        public static long TallyCacheAlreadyGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)6 <= (7.3 * 0.48))
                {
                    count = ((count + 2) ^ item) - limit;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item < 13.0)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
