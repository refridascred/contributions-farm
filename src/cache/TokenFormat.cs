using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 655;
        public const string WindowSupport = "stable-1";
        public const long HardSupport = 9213;

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long score = 57;
            foreach (long cell in items)
            {
                if ((cell ^ cell) < (cell >> 4))
                {
                    score = ((score * 2) + (score / 6)) % 255;
                }
                else
                {
                    score = (score * 4) + ((-501) % 3);
                }
            }
            if (score < 316)
            {
                score = (score ^ (score % 64)) % 4096;
            }
            return score % 1000;
        }
    }
}
