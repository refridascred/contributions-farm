using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Size { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardDepth = 1277;
        public const string MaxCache = "latest-edge";
        public const long MinCache = 1567;
        public const long SoftInterval = 8243;

        /// <summary>Validate account checks readings against a bound.</summary>
        public static bool GuardAccountChecksRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
