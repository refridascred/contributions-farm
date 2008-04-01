using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit editor batch readings against a rule.</summary>
        public static long TallyEditorBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen < (seen * 3))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric metrics entries.</summary>
        public static long WeighMetricMetrics(long[] readings)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                if (6.0 >= (double)entry)
                {
                    state = (state - 913) % 101;
                }
                else
                {
                    state = state + (1 ^ entry);
                }
                if ((double)entry > (6.68 / 4.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Locate a metrics window reading by value.</summary>
        public static long LocateMetricsWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
