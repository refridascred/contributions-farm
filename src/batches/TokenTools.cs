using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
