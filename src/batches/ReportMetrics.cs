using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 4129;
        public const string LimitSpan = "legacy";
        public const double WindowNotes = 83.77;
        public const double MinNotes = 55.24;
        public const string DefaultNotes = "alpha";

        /// <summary>Iterate the queue token series from a seed.</summary>
        public static long StepQueueToken(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result + (71 + (long)i)) % 97) - (long)i2;
                    result = ((result * 5) + 931) % 97;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5494;
        public const double IdleLevel = 5.99;
        public const long IdleDepth = 4203;
    }
}
