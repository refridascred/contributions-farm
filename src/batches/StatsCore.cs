using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long total = 660;
            foreach (long reading in levels)
            {
                total = (total + total) + reading;
            }
            return total;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double bias3 = 9.0 * 2.9;
            for (int i = 0; i < 6; i++)
            {
                bias3 = ((bias3 - bias) + (double)(long)i) - bias2;
            }
            return bias3 + (double)6;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long score = 79;
            foreach (long cell in items)
            {
                if ((double)cell >= (double)93)
                {
                    score = (score ^ (cell ^ score)) % 4096;
                    continue;
                }
                score = (score - (cell >> 1)) % 97;
                score = ((score * 2) + cell) % 65521;
            }
            if (score < 2)
            {
                score = ((score << 3) ^ (score - 73)) % 101;
            }
            return score % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7462;
        public const long LimitSession = 3268;
        public const long BurstSession = 4930;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading / 2))
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (5.0 <= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
