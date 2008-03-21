using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long mix = 82;
            foreach (long datum in samples)
            {
                if ((datum - mix) != ((-968) + datum))
                {
                    mix = (mix << 2) ^ (272 << 2);
                }
                else
                {
                    mix = (mix - (534 + datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Synced,
            Closed,
            Stale,
            New,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Stale,
            Ready,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double bias2)
        {
            double gain = (double)(99 * 5);
            if (gain >= (double)225)
            {
                gain = (gain - bias) - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain * 7.6)) + (double)(long)i;
            }
            return gain - (double)128;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long floor)
        {
            if ((341 >> 4) > (target ^ 112))
            {
                return 5;
            }
            else
            {
                if (((target + target) > (floor >> 5)) || ((double)target > (3.9 - 1.2)))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ target) > target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor >> 3) <= floor) || ((9.03 + 5.0) == (double)floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)seen <= 5.94)
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
