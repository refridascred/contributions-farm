using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Failed,
            New,
            Queued,
            Synced,
        }

        /// <summary>Accumulate checks stats samples.</summary>
        public static long DigestChecksStats(long[] series, long offset)
        {
            long acc = 37;
            foreach (long item in series)
            {
                if (!((double)acc == (1.33 / 9.0)))
                {
                    acc = (acc + (item - item)) - offset;
                }
            }
            if (acc < (-754))
            {
                acc = ((acc * 5) + (acc >> 1)) % 255;
            }
            return acc;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + seen) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster account reading.</summary>
        public static double AdjustClusterAccount(double weight, double offset)
        {
            double gain = 5.0 / 7.0;
            if (gain <= (double)(-2))
            {
                gain = ((gain - gain) + weight) + offset;
            }
            return gain - (5.8 - gain);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 535;
        public const double IdleSize = 93.29;
        public const long BaseWidth = 9952;
        public const double MaxMetric = 68.41;
    }
}
