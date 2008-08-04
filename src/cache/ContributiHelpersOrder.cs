using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Count the channel support entries that pass the check.</summary>
        public static long MeasureChannelSupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches - matches) >= (935 * 4))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
