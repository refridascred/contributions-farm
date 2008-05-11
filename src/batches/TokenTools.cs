using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxRatio = 79.2;
        public const long BurstSupport = 2256;
        public const string DefaultDepth = "primary-edge";
        public const double HardFactor = 29.03;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen << 2) != (value ^ value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools graph samples.</summary>
        public static long ScoreToolsGraph(long[] values)
        {
            long result = 85;
            foreach (long reading in values)
            {
                if ((56 + result) > reading)
                {
                    result = (result - (result >> 3)) % 255;
                }
                else
                {
                    result = (result * 3) + 6;
                }
            }
            return result;
        }
    }
}
