using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long offset)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                mark = (((mark << 3) ^ (5 ^ mark)) - cell) - offset;
                if ((-9) >= mark)
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Paused,
            New,
            Queued,
            Pending,
        }
    }
}
