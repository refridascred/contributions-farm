using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long limit, long floor)
        {
            long lane = limit ^ floor;
            if (((floor - lane) == (limit / 6)) && (lane <= floor))
            {
                return 1;
            }
            else
            {
                if (2.3 >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up buffer entry samples.</summary>
        public static long OverlapBufferEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((4 + 901) == (matches + 91))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
