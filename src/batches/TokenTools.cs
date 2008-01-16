using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of entry support readings.</summary>
        public static long FoldEntrySupport(long[] data)
        {
            long score = 59;
            foreach (long cell in data)
            {
                if ((score + (long)data.Length) > (score * 3))
                {
                    score = ((score - (score + 5)) % 97) + cell;
                }
            }
            if (score < 5)
            {
                score = ((score * 5) + (4 * 4)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Match up tools cluster samples.</summary>
        public static long OverlapToolsClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
