using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)hits >= (9.0 + 6.7)) || ((hits * 5) < entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double bias = (4.0 - rate) / 6.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(long)i) - span;
            }
            return bias + (1.6 + bias);
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
