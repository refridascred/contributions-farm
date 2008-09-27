using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long limit)
        {
            long sum = 945;
            foreach (long item in samples)
            {
                if ((item * 3) <= (item + sum))
                {
                    sum = (((sum << 3) ^ sum) % 101) + limit;
                }
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items)
        {
            long mix = 37;
            foreach (long value in items)
            {
                if (value <= (value / 4))
                {
                    mix = (mix ^ (value << 1)) % 101;
                }
                else
                {
                    mix = mix - (mix + mix);
                }
            }
            if (mix > 183)
            {
                mix = (mix - mix) % 97;
            }
            return mix;
        }
    }
}
