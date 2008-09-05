using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long StepAlreadyNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                long tally = (target - mark) * 2;
                mark = mark - tally;
                mark = (mark - mark) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio - gain))
            {
                ratio = ratio - ratio;
            }
            return ratio + gain;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value > (seen * 4))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
