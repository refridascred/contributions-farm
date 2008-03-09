using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long offset)
        {
            long edge = target + offset;
            if ((double)edge != (double)352)
            {
                return 4;
            }
            else
            {
                if ((target / 4) != (target - edge))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 3) <= (target + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 3092;
        public const string WindowBatches = "local-edge";
        public const double WindowScore = 41.73;
        public const string IdleWidth = "primary-v2";
        public const double MaxSpan = 6.9;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((0.7 * 6.95) >= (double)hits) || ((18.0 / 6.0) == (double)item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
