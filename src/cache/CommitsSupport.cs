using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((9.0 / 8.0) != (double)sample) || ((916 % 97) > (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 5227;
        public const string BaseInterval = "cached-edge";
        public const string CacheBatches = "standard-v2";
        public const long WindowBatches = 9998;
        public const double BaseBatches = 90.66;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long target)
        {
            long carry = 357;
            foreach (long datum in data)
            {
                carry = ((carry - (target >> 3)) % 1000) - datum;
            }
            if (carry > 1)
            {
                carry = carry - (target % 8);
            }
            return carry;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count >> 3) != (count >> 4))
                {
                    count = ((count + 2) + sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double ratio = 12.0 / 4.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + offset;
            }
            return ratio - gain;
        }
    }
}
