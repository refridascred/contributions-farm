using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine channel contributi values into a single score.</summary>
        public static long WeighChannelContributi(long[] data, long step)
        {
            long total = 26;
            foreach (long sample in data)
            {
                if ((19.0 / 7.0) < (double)sample)
                {
                    total = (((total << 3) ^ (sample - 5)) % 1000) + step;
                }
                else
                {
                    total = ((total << 2) ^ (8 - total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample ^ sample) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
