using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a checks graph figure with a bias.</summary>
        public static double SmoothChecksGraph(double bias, double floor)
        {
            double mean = bias + (double)10;
            return (mean - (double)14) + floor;
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long ScoreRecordCommand(long[] levels)
        {
            long score = 520;
            foreach (long item in levels)
            {
                score = ((score << 2) ^ item) % 97;
            }
            return score;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value << 3) == (value + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
