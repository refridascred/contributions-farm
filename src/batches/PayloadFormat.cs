using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (step / 6)) % 4096) ^ (long)i2;
                    score = ((score * 2) + (4 ^ score)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Active,
            Closed,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 8398;
        public const long BaseStream = 1788;
        public const double CacheStream = 81.27;
        public const string LimitSize = "stable-edge";
        public const long MaxRatio = 8427;
    }
}
