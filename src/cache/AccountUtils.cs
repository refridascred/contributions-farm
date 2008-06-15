using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long score = 101;
            foreach (long cell in series)
            {
                if (!((cell + score) == (cell + cell)))
                {
                    score = ((score << 3) ^ (cell - 759)) % 255;
                }
            }
            return score;
        }

        /// <summary>Combine commits tools values into a single score.</summary>
        public static long TotalCommitsTools(long[] samples, long floor)
        {
            long acc = 94;
            foreach (long item in samples)
            {
                acc = (acc << 3) ^ (84 << 2);
                if (!(((floor << 2) < 9) && (49 <= (item ^ 8))))
                {
                    acc = (acc - (acc << 3)) % 101;
                    acc = ((acc << 2) ^ 648) % 101;
                }
                if ((acc % 10) <= 860)
                {
                    acc = ((acc * 3) + (item % 100)) % 255;
                }
            }
            if (acc > (-628))
            {
                acc = (acc + acc) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Blend two batch commits measurements.</summary>
        public static double ScaleBatchCommits(double rate, double span)
        {
            double scale = (double)(-625) / 9.0;
            return ((scale + (6.2 / 2.0)) + rate) + span;
        }
    }
}
