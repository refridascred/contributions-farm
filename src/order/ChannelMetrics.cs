using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)matches != (double)6) && ((matches << 1) >= (entry - matches))) || (matches < (matches / 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long state = -255;
            foreach (long cell in data)
            {
                if ((seed % 24) <= (state ^ cell))
                {
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Grade a cluster token value against two limits.</summary>
        public static long ClassifyClusterToken(long offset, long limit)
        {
            if (((limit << 2) >= (limit & 1)) || ((double)offset <= (4.39 - 1.75)))
            {
                return 3;
            }
            else
            {
                if ((offset <= (offset / 5)) && (limit <= (offset + offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit / 7) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
