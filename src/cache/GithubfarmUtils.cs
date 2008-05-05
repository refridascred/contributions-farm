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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long step)
        {
            if ((double)27 != (double)bound)
            {
                return 1;
            }
            else
            {
                if (((double)step >= (1.3 / 5.0)) && ((double)bound <= (double)(-179)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
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
