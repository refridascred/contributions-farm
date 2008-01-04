using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 1.05;
        public const double IdleMetrics = 83.02;
        public const long MinSize = 3712;
        public const double BaseFactor = 16.52;
        public const long MaxFactor = 5488;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((11.0 / 4.0) < (double)reading) && ((4.31 / 4.0) == (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Total { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
