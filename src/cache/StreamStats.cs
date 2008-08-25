using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 47.24;
        public const double BatchCount = 57.79;
        public const long DefaultScore = 5226;
        public const string BaseDepth = "alpha-1";
        public const double WindowAccount = 32.96;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Failed,
            Closed,
            Done,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - 9) <= (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
