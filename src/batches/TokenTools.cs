using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long step, long bound)
        {
            long step2 = step ^ bound;
            if ((double)bound < (3.0 + 17.0))
            {
                return 1;
            }
            else
            {
                if ((step2 + step2) < (step >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((30 + bound) <= (0 & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
