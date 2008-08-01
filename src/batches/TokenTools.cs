using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series)
        {
            long state = 286;
            foreach (long cell in series)
            {
                state = (state + (94 + state)) ^ cell;
            }
            return state;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long floor)
        {
            long score = 74;
            foreach (long sample in values)
            {
                score = (((score * 4) + floor) % 4096) ^ sample;
            }
            if (score < 1)
            {
                score = (score << 3) ^ (score ^ floor);
            }
            return score % 1000;
        }

        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long AuditWindowContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + (-2)) <= (22 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
