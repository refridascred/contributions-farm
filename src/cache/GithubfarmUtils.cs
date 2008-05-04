using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of already batches readings.</summary>
        public static long CombineAlreadyBatches(long[] data, long seed)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if (!((1.01 / 7.0) <= (double)seed))
                {
                    mix = mix ^ (value * 5);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 13.0))
            {
                ratio = (ratio + offset) + scale;
            }
            else
            {
                ratio = ratio + (offset / 6.0);
            }
            return ratio + (double)0;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell - cell) > (862 / 6)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
