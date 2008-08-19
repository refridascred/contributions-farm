using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double ratio, double offset)
        {
            double ratio2 = (double)(9 + 5);
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (((ratio2 + 6.0) + (double)(long)i) - ratio) - offset;
            }
            return ratio2 + (double)21;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9438;
        public const long BurstSize = 7281;
        public const long WindowLevel = 1460;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((double)mix != (12.0 - 17.0))
                {
                    mix = (mix ^ (840 + mix)) % 97;
                }
                if (((mix + origin) > mix) || ((8.0 + 10.0) <= (double)mix))
                {
                    mix = ((mix * 3) + mix) % 65521;
                }
                else
                {
                    mix = mix ^ ((long)i >> 3);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
