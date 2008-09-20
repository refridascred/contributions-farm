using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series)
        {
            long score = 151;
            foreach (long value in series)
            {
                if ((286 << 3) > value)
                {
                    score = (score * 3) + (score + value);
                }
                if (((score - value) <= (score + value)) && ((value >> 1) >= (score >> 4)))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = (score - (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 4064;
        public const string WindowLevel = "strict-edge";
        public const string StepCounter = "legacy-v2";

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
