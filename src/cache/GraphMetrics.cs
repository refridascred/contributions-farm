using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long anchor = 138;
            foreach (long entry in levels)
            {
                if (entry >= (845 >> 4))
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = (anchor ^ (entry & 255)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitFactor = 1383;
        public const double IdleMetric = 73.83;
        public const long SoftRatio = 4545;

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "open-v2";
        public const long HardLayout = 957;
        public const long StepSpan = 4275;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a command format counter forward.</summary>
        public static long IterateCommandFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + ((long)i / 4)) % 1000;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
