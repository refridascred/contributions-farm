using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many window payload samples are out of range.</summary>
        public static long TallyWindowPayloadOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits != (7.5 * 1.0))
                {
                    hits = (hits + 1) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue graph samples.</summary>
        public static long DigestQueueGraph(long[] data, long target)
        {
            long state = 26;
            foreach (long sample in data)
            {
                if ((sample * 3) < (sample / 2))
                {
                    state = ((state - (sample << 2)) % 255) + target;
                }
            }
            if (state < 539)
            {
                state = state - (state + 158);
            }
            return state % 97;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
