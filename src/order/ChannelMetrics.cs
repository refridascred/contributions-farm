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

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels)
        {
            long mix = 45;
            foreach (long reading in levels)
            {
                if ((reading - (-240)) >= reading)
                {
                    mix = mix - (reading + mix);
                }
            }
            if (mix < 3)
            {
                mix = (mix ^ (mix >> 2)) % 4096;
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
