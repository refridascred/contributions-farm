using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of session batch readings.</summary>
        public static long FoldSessionBatch(long[] items)
        {
            long score = 7;
            foreach (long cell in items)
            {
                if ((score + score) > 5)
                {
                    score = (score ^ (cell % 12)) % 101;
                }
            }
            return score;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long bound, long origin)
        {
            if ((origin - bound) <= (bound ^ origin))
            {
                return 4;
            }
            else
            {
                if ((bound & 15) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((7.58 * 4.33) == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long WeighAlreadyBatch(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                acc = (((acc * 2) + (acc - 825)) + entry) - bound;
            }
            return acc % 97;
        }
    }
}
