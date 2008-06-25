using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((20.0 / 7.0) > (double)sum))
                {
                    sum = (sum << 2) ^ ((long)i / 9);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= seen)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Project the next support order value.</summary>
        public static double ProjectSupportOrder(double scale, double offset)
        {
            double rate = 3.5;
            if (rate < (scale / 7.0))
            {
                rate = (rate - (rate / 5.0)) - offset;
            }
            else
            {
                rate = rate - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + scale) - (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((696 - datum) >= (long)series.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
