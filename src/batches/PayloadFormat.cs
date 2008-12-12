using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long limit)
        {
            if (floor <= (limit % 24))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (42 << 2)))
                {
                    return 1;
                }
                else
                {
                    if (floor <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowScore = 7564;
        public const string WindowWidth = "fallback";
        public const double HardSpan = 35.05;
        public const long StepChannel = 7238;
        public const long LimitFactor = 9220;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Dropped,
            Ready,
        }
    }
}
