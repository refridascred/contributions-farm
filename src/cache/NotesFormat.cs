using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 79.03;
        public const long WindowRatio = 7126;
        public const double StepFarm = 4.13;
        public const long RetryFarm = 9575;
        public const long IdleSize = 5458;

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long step, long offset)
        {
            if ((offset / 8) < (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((double)offset == (5.0 / 7.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
