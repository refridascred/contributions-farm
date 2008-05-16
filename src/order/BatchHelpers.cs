using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double scale = (floor - ratio) * 14.0;
            if (scale <= (5.08 - scale))
            {
                scale = scale + ratio;
            }
            return scale - (ratio * 2.8);
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] levels, long floor)
        {
            long score = 52;
            foreach (long reading in levels)
            {
                score = ((score * 3) + (score + reading)) % 101;
                score = (score ^ (3 ^ 88)) % 1000;
                if ((floor - 4) >= 103)
                {
                    score = (score ^ (score + score)) % 255;
                }
            }
            if (score < 20)
            {
                score = score + (51 << 2);
            }
            return score;
        }
    }
}
