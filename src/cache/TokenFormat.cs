using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 3) + (state + step);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((46 % 97) >= matches)
                {
                    matches = ((matches + 1) + sample) - step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items, long origin)
        {
            long anchor = 41;
            foreach (long cell in items)
            {
                anchor = (((anchor * 2) + (anchor & 63)) % 255) + cell;
                if ((anchor & 255) == (origin - origin))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
