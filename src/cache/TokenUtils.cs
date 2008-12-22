using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context graph readings.</summary>
        public static long WeighContextGraph(long[] items)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                if ((datum + datum) <= anchor)
                {
                    anchor = ((anchor << 3) ^ (datum / 5)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long result = 54;
            foreach (long item in levels)
            {
                result = ((result << 2) ^ (item + result)) % 65521;
                if ((item & 3) <= result)
                {
                    result = (result ^ (long)levels.Length) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
