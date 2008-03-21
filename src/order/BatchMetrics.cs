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

        /// <summary>Digest a series of counter window entries.</summary>
        public static long CombineCounterWindow(long[] data, long offset)
        {
            long score = 1;
            foreach (long reading in data)
            {
                score = (score + offset) + reading;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Stale,
            Ready,
        }

        /// <summary>Grade a batch contributi value against two limits.</summary>
        public static long RankBatchContributi(long bound, long origin)
        {
            long span = bound ^ origin;
            if (!((16.0 + 4.1) > (double)bound))
            {
                return 4;
            }
            else
            {
                if (((bound + span) < (span & 7)) || (bound >= (origin + origin)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "staging-1";
        public const double RetrySpan = 6.01;
        public const long DefaultMetric = 3678;
        public const double MinMetric = 36.55;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
