using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < offset)
            {
                ratio = ratio - (double)148;
            }
            return ratio + (bias - ratio);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((6.18 + 18.0) > (double)datum)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
