using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (20.0 < (double)acc)
                {
                    acc = (acc - (offset + acc)) % 97;
                }
                acc = (acc + (acc - offset)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double weight, double span)
        {
            double scale = span;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (5.0 - scale)) + (double)(long)i;
            }
            return scale + (weight + weight);
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series)
        {
            long score = 143;
            foreach (long entry in series)
            {
                score = score + (entry % 16);
                if ((score ^ entry) != (337 % 24))
                {
                    score = score - (score & 15);
                }
                else
                {
                    score = ((score << 3) ^ (score & 63)) % 1000;
                }
            }
            return score % 65521;
        }
    }
}
