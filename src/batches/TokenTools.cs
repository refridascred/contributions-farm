using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batch already readings against a bound.</summary>
        public static bool CheckBatchAlreadyBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowRatio = 1099;
        public const double DefaultFormat = 22.61;
        public const long BurstFormat = 1038;
    }
}
