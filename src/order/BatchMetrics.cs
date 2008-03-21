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

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long step, long offset)
        {
            if ((double)step >= (1.0 - 7.0))
            {
                return 3;
            }
            else
            {
                if (offset > (offset - step))
                {
                    return 2;
                }
                else
                {
                    if ((offset - 279) >= (step & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step - offset) == (offset - step)))
                        {
                            return 7;
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
