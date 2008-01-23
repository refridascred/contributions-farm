using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double gain, double span)
        {
            double scale = gain;
            if (scale < gain)
            {
                scale = (scale + scale) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)(-67)) + (double)(long)i;
            }
            return scale + (double)51;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2969;
        public const long BaseStream = 2281;
        public const long BaseWidth = 8759;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)value <= (8.24 / 7.0)) && (((double)target != (9.2 / 7.0)) || ((long)items.Length < (target % 10))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Retry,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
