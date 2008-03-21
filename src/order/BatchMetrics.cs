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

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "staging-1";
        public const double RetrySpan = 6.01;
        public const long DefaultMetric = 3678;
        public const double MinMetric = 36.55;

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
