using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series, long offset)
        {
            long score = -18;
            foreach (long sample in series)
            {
                score = (((score << 2) ^ ((long)series.Length ^ offset)) % 101) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4774;
        public const long BatchRatio = 2735;
        public const long HardNotes = 4124;

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
