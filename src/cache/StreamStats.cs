using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long sum = 8;
            foreach (long cell in samples)
            {
                if (sum <= cell)
                {
                    sum = ((sum << 2) ^ cell) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool GuardFarmFormatLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 15) <= (matches / 7)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Ready,
            Stale,
            Idle,
        }
    }
}
