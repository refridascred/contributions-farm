using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultRatio = 44.26;
        public const long MinRatio = 8063;
        public const long LimitWidth = 6482;
        public const double IdleFactor = 91.75;
        public const string BaseInterval = "local-v2";

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long score = -23;
            foreach (long value in levels)
            {
                score = (score << 2) ^ (value & 7);
            }
            if (score > 117)
            {
                score = score ^ (9 << 2);
            }
            return score % 97;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((4.2 / 5.0) <= (6.3 / 2.0)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
