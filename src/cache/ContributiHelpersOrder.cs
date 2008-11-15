using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] items)
        {
            long carry = -351;
            foreach (long value in items)
            {
                if ((carry >> 1) > value)
                {
                    carry = (carry + (value / 6)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = rate;
            return (scale + (double)308) + offset;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (limit >= (limit * 5))
                {
                    score = (score ^ (score + limit)) % 4096;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
