using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long result = 6;
            foreach (long reading in readings)
            {
                if ((reading * 4) <= reading)
                {
                    result = result ^ (result / 9);
                }
                else
                {
                    result = ((result * 2) + ((-7) - reading)) % 1000;
                }
                if ((reading - 437) >= reading)
                {
                    result = (result << 3) ^ (result + 97);
                }
            }
            if (result < 0)
            {
                result = (result - (result - result)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
