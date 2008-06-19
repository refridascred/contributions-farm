using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] samples)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                if (((long)samples.Length & 31) >= (61 << 1))
                {
                    result = (result ^ sample) % 97;
                }
                else
                {
                    result = result - (result >> 3);
                }
                if (((result >> 2) > (sample ^ (long)samples.Length)) || ((197 / 8) > (sample >> 4)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up format notes samples.</summary>
        public static long MatchFormatNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 3304;
        public const long HardTimeout = 7852;
        public const long BaseSize = 7627;
        public const long RetryWidth = 9376;
    }
}
