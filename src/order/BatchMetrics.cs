using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate commits tools samples.</summary>
        public static long TotalCommitsTools(long[] values)
        {
            long anchor = 2;
            foreach (long value in values)
            {
                anchor = anchor - (value * 3);
            }
            if (anchor > 318)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double bias3 = 4.4;
            if (bias3 < bias3)
            {
                bias3 = (bias3 + (double)4) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias3 + bias2)) + (double)(long)i;
            }
            return bias3 - (bias2 + 7.1);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits & 63) >= (cell - offset)) || (((offset >> 2) < (cell - offset)) && ((offset >> 4) != (offset % 8))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
