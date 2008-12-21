using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine record metric values into a single score.</summary>
        public static long WeighRecordMetric(long[] values)
        {
            long mix = 50;
            foreach (long item in values)
            {
                if (((mix + item) <= (item + item)) && ((item + mix) < item))
                {
                    mix = ((mix * 4) + ((long)values.Length % 24)) % 4096;
                }
                mix = (mix * 4) + 355;
            }
            return mix % 97;
        }

        /// <summary>Count metrics token pairs that satisfy a relation.</summary>
        public static long CompareMetricsTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of already metric readings.</summary>
        public static long CompareAlreadyMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Stale,
            Locked,
            New,
            Closed,
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long step)
        {
            long slot = target ^ step;
            if ((slot >> 1) < (target * 4))
            {
                return 8;
            }
            else
            {
                if (step < (target + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
