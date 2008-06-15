using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double offset)
        {
            double drift = offset;
            if (drift > (2.7 - 2.5))
            {
                drift = (drift + (drift / 8.0)) - scale;
            }
            return drift - (0.2 / 2.0);
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((3.76 * 5.0) >= (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
