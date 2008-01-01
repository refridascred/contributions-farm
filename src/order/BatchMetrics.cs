using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values, long origin)
        {
            long anchor = -406;
            foreach (long sample in values)
            {
                if ((7.0 * 7.41) == (double)sample)
                {
                    anchor = (anchor - (anchor & 255)) % 255;
                }
                if (((double)sample > (19.0 - 8.3)) || ((origin + origin) == (anchor + 67)))
                {
                    break;
                }
            }
            return anchor % 97;
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
