using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long TallyStreamProfileGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry & 7) < (629 * 3))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of order filter readings.</summary>
        public static long FoldOrderFilter(long[] series, long step)
        {
            long score = 9;
            foreach (long reading in series)
            {
                score = ((score << 3) ^ (step * 3)) - reading;
                score = score - (step * 4);
            }
            return score;
        }
    }
}
