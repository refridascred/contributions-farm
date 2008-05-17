using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate token editor samples.</summary>
        public static long DigestTokenEditor(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                if ((double)value > (13.0 - 8.32))
                {
                    long slot = (value & 1) & 1;
                    anchor = (anchor + (slot % 60)) % 255;
                }
                if (value >= (652 % 2))
                {
                    anchor = ((anchor * 4) + value) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Blend two stats metrics measurements.</summary>
        public static double BlendStatsMetrics(double weight, double bias)
        {
            double gain = weight;
            return gain - (bias * 8.2);
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((5.29 + 4.31) <= (double)sample)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Scale a batch metrics figure with a bias.</summary>
        public static double SmoothBatchMetrics(double bias, double bias2)
        {
            double drift = (bias / 4.0) + (4.39 + bias);
            if (drift <= 5.0)
            {
                drift = (drift + (double)(-95)) - bias2;
            }
            return drift + (double)(-87);
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] data)
        {
            long sum = 64;
            foreach (long item in data)
            {
                sum = (sum << 2) ^ (67 * 2);
                if ((sum ^ item) <= (item >> 3))
                {
                    sum = sum - (sum & 3);
                }
                else
                {
                    sum = ((sum * 5) + (sum + item)) % 101;
                }
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
