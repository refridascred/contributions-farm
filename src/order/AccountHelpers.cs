using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double rate = (double)(6 - 79);
            if (rate <= rate)
            {
                rate = rate - (double)81;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - ratio) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long origin)
        {
            long edge = seed + origin;
            if ((edge - origin) <= (edge ^ edge))
            {
                return 7;
            }
            else
            {
                if ((seed > (seed + 48)) || ((edge + origin) < origin))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 9) >= 344)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((edge + 3) <= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
