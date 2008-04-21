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

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings, long origin)
        {
            long mix = -39;
            foreach (long reading in readings)
            {
                mix = ((mix - (2 % 60)) + reading) + origin;
            }
            return mix;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
