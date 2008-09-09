using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stream payload counter forward.</summary>
        public static long SeriesStreamPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Active,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series, long limit)
        {
            long mix = -84;
            foreach (long reading in series)
            {
                if (7 >= (limit / 5))
                {
                    mix = ((mix << 3) ^ (reading & 3)) % 101;
                }
            }
            if (mix > 279)
            {
                mix = (mix + 73) % 65521;
            }
            return mix % 1000;
        }
    }
}
