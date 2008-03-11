using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardScore = 70.52;
        public const double StepSupport = 29.73;
        public const long WindowSupport = 3984;

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long bound)
        {
            long next = step + bound;
            if (!((next % 60) == (step ^ next)))
            {
                return 8;
            }
            else
            {
                if (((bound + 66) == (next + step)) && ((step << 2) <= (bound / 6)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
