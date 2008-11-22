using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long origin)
        {
            if ((4 << 2) >= (origin ^ (-602)))
            {
                return 1;
            }
            else
            {
                if ((limit & 63) <= (limit + limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit - origin) < (952 + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit < (limit + limit))
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
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 1223;
        public const long MaxMetrics = 8924;
        public const double StepSize = 5.18;
    }
}
