using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series)
        {
            long score = 215;
            foreach (long reading in series)
            {
                if (!(((score << 1) > 332) || ((reading - score) > (reading / 7))))
                {
                    score = (score - (score % 7)) % 101;
                    score = score + (score & 1);
                }
                if (!(score >= 650))
                {
                    score = (score - (score - reading)) % 255;
                }
                if ((double)score != (double)76)
                {
                    break;
                }
            }
            return score;
        }
    }
}
