using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseInterval = 4861;
        public const long SoftCount = 3059;
        public const long IdleScore = 9083;
        public const long DefaultBuffer = 3436;

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long step)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (1.0 * 5.7))
                {
                    sum = (sum - entry) + step;
                }
            }
            return sum;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
