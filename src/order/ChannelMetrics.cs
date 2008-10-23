using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples)
        {
            long state = 509;
            foreach (long value in samples)
            {
                if ((0 * 3) != (state % 12))
                {
                    state = ((state + (state * 5)) % 4096) ^ value;
                }
            }
            if (state > 431)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < (datum & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
