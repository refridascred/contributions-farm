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

        /// <summary>Grade a format payload value against two limits.</summary>
        public static long BucketFormatPayload(long target, long seed)
        {
            long step = target - seed;
            if (!((20.0 / 9.0) >= (double)target))
            {
                return 3;
            }
            else
            {
                if ((double)seed > (1.1 / 6.0))
                {
                    return 8;
                }
                else
                {
                    if ((target * 5) <= (step % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
