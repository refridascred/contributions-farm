using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double scale = 5.73;
            if (scale >= scale)
            {
                scale = (scale + (double)(-98)) - ratio;
            }
            return scale + floor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 8274;
        public const long BatchSize = 9248;
        public const long MinAccount = 8556;
        public const long SoftCount = 7030;

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
