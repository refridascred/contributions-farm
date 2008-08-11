using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 5102;
        public const long HardContext = 3661;
        public const string BurstDepth = "legacy-1";

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1348;
        public const string IdleTimeout = "standard";
        public const long MaxDepth = 7974;
    }
}
