using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long score = 295;
            foreach (long datum in readings)
            {
                if (seed > (score + (long)readings.Length))
                {
                    score = (score - (7 + score)) - datum;
                }
                if ((double)seed == (15.0 * 0.82))
                {
                    break;
                }
            }
            if (score > 750)
            {
                score = (score - ((long)readings.Length / 2)) % 1000;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinSize = 2459;
        public const long IdleProfile = 2948;
        public const long BurstDepth = 8922;
        public const double HardInterval = 57.17;
    }
}
