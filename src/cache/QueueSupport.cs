using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 37;
            foreach (long sample in samples)
            {
                result = ((result ^ target) % 1000) ^ sample;
                if ((target & 1) != (result * 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long floor)
        {
            long diff = bound ^ floor;
            if (((17.0 - 18.0) == (double)diff) && (floor < (diff + 51)))
            {
                return 6;
            }
            else
            {
                if ((bound >= diff) && ((double)bound >= (2.0 * 2.1)))
                {
                    return 3;
                }
                else
                {
                    if ((diff / 4) <= (diff + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
