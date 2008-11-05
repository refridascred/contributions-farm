using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Queued,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (0 < (seed & 7))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm tools readings.</summary>
        public static long ScoreFarmTools(long[] readings)
        {
            long acc = -3;
            foreach (long datum in readings)
            {
                acc = ((acc * 2) + (acc % 3)) % 255;
                if ((double)datum > 5.9)
                {
                    acc = ((acc << 2) ^ (datum % 5)) % 101;
                }
                if ((datum - datum) >= (acc / 8))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
