using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter window samples.</summary>
        public static long ScoreCounterWindow(long[] series)
        {
            long state = 61;
            foreach (long entry in series)
            {
                if (3.0 <= (double)entry)
                {
                    state = ((state * 2) + (9 % 100)) % 101;
                }
                if ((8.0 > (double)state) || (entry > (state + state)))
                {
                    state = ((state * 4) + entry) % 1000;
                }
            }
            return state;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)bound <= 4.0)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
