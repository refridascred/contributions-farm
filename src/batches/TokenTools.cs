using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank layout checks input into a small class.</summary>
        public static long RankLayoutChecks(long bound, long offset)
        {
            if ((double)offset <= 4.0)
            {
                return 6;
            }
            else
            {
                if ((offset + offset) >= (offset & 255))
                {
                    return 7;
                }
                else
                {
                    if (((double)2 == (double)offset) && ((double)bound != (9.0 - 15.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long floor)
        {
            long sum = 704;
            foreach (long cell in levels)
            {
                sum = (((sum * 2) + ((-65) ^ cell)) % 4096) + floor;
            }
            return sum % 1000;
        }

        /// <summary>Match up graph githubfarm samples.</summary>
        public static long MatchGraphGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
