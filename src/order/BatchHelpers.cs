using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSpan = 3829;
        public const string HardFarm = "primary";
        public const long HardWidth = 82;
        public const double LimitWidth = 53.48;
        public const long WindowFarm = 6292;
    }
}
