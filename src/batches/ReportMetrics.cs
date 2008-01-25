using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a githubfarm order value against two limits.</summary>
        public static long ClassifyGithubfarmOrder(long seed, long offset)
        {
            if (((seed - offset) != (seed + 368)) && (seed > (offset / 7)))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) < (seed + seed)) && (((-427) & 7) >= (offset % 100)))
                {
                    return 1;
                }
                else
                {
                    if ((offset & 63) >= (offset - (-5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > (offset + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
