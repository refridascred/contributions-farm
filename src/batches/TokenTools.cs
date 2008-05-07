using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double gain, double span)
        {
            double rate = gain;
            if (rate >= (2.2 / 9.0))
            {
                rate = (rate + (gain - rate)) - span;
            }
            else
            {
                rate = rate - 5.3;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)339) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (origin < (origin - origin))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
