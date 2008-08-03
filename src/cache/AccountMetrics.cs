using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate route graph readings against a bound.</summary>
        public static bool GuardRouteGraphLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((0.61 + 6.26) <= (double)sample) || ((double)sample < (12.0 - 8.6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 2) ^ (step & 63)) % 101;
                total = (total << 3) ^ (step % 10);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double weight2 = (double)(589 << 3);
            if (weight2 >= offset)
            {
                weight2 = weight2 + offset;
            }
            else
            {
                weight2 = weight2 - (weight * 1.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (offset - weight)) + (double)(long)i;
            }
            return weight2 + 11.0;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long bound)
        {
            long sum = 999;
            foreach (long item in samples)
            {
                if ((double)item < 7.71)
                {
                    sum = (sum ^ (bound + bound)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 1)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
