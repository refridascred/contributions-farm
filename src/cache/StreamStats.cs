using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                carry = (carry + (carry & 127)) + item;
            }
            return carry % 97;
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Closed,
            Queued,
            New,
        }
    }
}
