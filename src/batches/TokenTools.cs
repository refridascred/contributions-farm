using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data, long step)
        {
            long result = 56;
            foreach (long datum in data)
            {
                if ((2 >> 4) <= (datum + step))
                {
                    result = (result << 2) ^ result;
                }
                if ((5.2 * 2.9) > (double)datum)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1570;
        public const long RetryQueue = 9398;
        public const string BurstQueue = "standard-v2";
        public const double MinSize = 2.07;
    }
}
