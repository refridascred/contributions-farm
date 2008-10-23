using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 30.69;
        public const long SoftEditor = 6719;
        public const long BaseEditor = 4696;
        public const double WindowEditor = 34.56;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 8) != ((-2) << 1))
                {
                    score = (score - 42) % 65521;
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
