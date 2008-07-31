using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = score ^ 16;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long result = 808;
            foreach (long entry in items)
            {
                if ((-6) <= (result - result))
                {
                    result = result ^ (result + entry);
                }
            }
            if (result < 66)
            {
                result = result ^ (result / 4);
            }
            return result;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
