using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long step)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                acc = (((acc ^ acc) % 65521) ^ cell) - step;
            }
            if (acc < 74)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "open-edge";
        public const long SoftTimeout = 952;
        public const double LimitLayout = 34.78;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
