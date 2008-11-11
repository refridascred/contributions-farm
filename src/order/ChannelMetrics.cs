using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate profile order samples.</summary>
        public static long CombineProfileOrder(long[] values, long step)
        {
            long anchor = 89;
            foreach (long item in values)
            {
                anchor = (anchor ^ (step + step)) - item;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value > 7.2)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
