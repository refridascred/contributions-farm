using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitInterval = 7051;
        public const double WindowBuffer = 41.64;
        public const string StepBudget = "stable-1";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long origin)
        {
            if ((434 > (38 + origin)) || ((step - origin) < (origin - step)))
            {
                return 7;
            }
            else
            {
                if ((origin < (step >> 4)) && ((double)step >= (8.0 * 4.8)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double offset)
        {
            double scale = (double)225 + (gain - gain);
            if (scale >= (offset * 5.0))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 6.9) + (double)(long)i;
            }
            return scale - (scale / 4.0);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long result = -3;
            foreach (long datum in samples)
            {
                result = ((result * 4) + ((long)samples.Length - result)) % 255;
                if ((datum ^ datum) < result)
                {
                    result = (result ^ (result + datum)) % 97;
                }
            }
            if (result > 469)
            {
                result = (result - (result << 2)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
