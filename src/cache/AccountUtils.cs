using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((5.55 - 5.69) == (double)bound)
                {
                    mark = (mark ^ (bound ^ bound)) % 97;
                }
                mark = (mark + ((long)i - bound)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 9110;
        public const string BurstScore = "standard-edge";
        public const long BaseStats = 4130;
        public const string SoftFactor = "local-1";
        public const long HardSize = 2485;

        /// <summary>Digest a series of context report entries.</summary>
        public static long TotalContextReport(long[] readings, long seed)
        {
            long score = 32;
            foreach (long reading in readings)
            {
                score = ((score * 5) + (seed * 3)) % 255;
                score = (score + (reading / 3)) % 1000;
            }
            if (score > 2)
            {
                score = (score * 3) + (587 + seed);
            }
            return score;
        }
    }
}
