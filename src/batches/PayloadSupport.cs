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

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data, long bound)
        {
            long total = -697;
            foreach (long entry in data)
            {
                if (((bound ^ entry) <= (long)data.Length) || ((entry + entry) > (total * 3)))
                {
                    total = (total + total) % 97;
                }
                else
                {
                    total = (total - total) % 65521;
                }
            }
            if (total > 99)
            {
                total = total ^ bound;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1348;
        public const string IdleTimeout = "standard";
        public const long MaxDepth = 7974;
    }
}
