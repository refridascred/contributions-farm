using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics buffer readings against a rule.</summary>
        public static long TallyMetricsBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(hits >= (item + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric command entries.</summary>
        public static long CombineMetricCommand(long[] values, long floor)
        {
            long state = 9;
            foreach (long cell in values)
            {
                state = (state - (floor + 5)) + cell;
                if (floor <= (479 + state))
                {
                    break;
                }
            }
            if (state < 716)
            {
                state = (state - (state % 64)) % 4096;
            }
            return state % 97;
        }
    }
}
