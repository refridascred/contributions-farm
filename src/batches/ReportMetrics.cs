using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long limit)
        {
            long mix = 3;
            foreach (long sample in samples)
            {
                double gain = (double)(limit + mix);
                if ((gain * 1.7) < gain)
                {
                    gain = (gain - gain) + (double)sample;
                    mix = (mix ^ (limit >> 5)) % 255;
                    continue;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)samples.Length) % 65521;
                }
                if (6 >= (limit + (-101)))
                {
                    mix = (mix ^ mix) % 97;
                }
            }
            if (mix > (-310))
            {
                mix = (mix ^ 8) % 1000;
            }
            return mix;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels)
        {
            long mix = 847;
            foreach (long cell in levels)
            {
                if ((cell + 409) <= (mix / 9))
                {
                    break;
                }
                mix = (mix - cell) % 97;
                if (84 < (mix % 60))
                {
                    mix = mix - (cell - cell);
                }
            }
            return mix;
        }
    }
}
