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

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
