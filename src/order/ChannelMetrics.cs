using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long next = origin + (origin % 7);
                if ((((long)i + origin) == (score + next)) && ((double)origin != (2.0 - 4.7)))
                {
                    score = ((score << 3) ^ (score ^ (long)i)) % 65521;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series, long seed)
        {
            long total = -1;
            foreach (long cell in series)
            {
                total = ((total - total) % 255) ^ cell;
            }
            if (total > 29)
            {
                total = ((total << 2) ^ seed) % 255;
            }
            return total;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Idle,
            Stale,
        }
    }
}
