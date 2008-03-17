using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings, long seed)
        {
            long acc = 781;
            foreach (long value in readings)
            {
                acc = (acc + (4 - value)) % 255;
                if ((double)seed < (4.14 + 2.37))
                {
                    break;
                }
            }
            if (acc < 268)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score << 3) ^ (long)i2) % 101;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 7196;
        public const long LimitCommits = 1243;
        public const double DefaultCommits = 20.25;
        public const long BaseCommits = 36;
    }
}
