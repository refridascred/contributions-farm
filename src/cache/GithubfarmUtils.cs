using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double load = rate;
            if (load < rate)
            {
                load = (load - rate) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (rate / 4.0);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] data)
        {
            long carry = 638;
            foreach (long reading in data)
            {
                carry = (carry << 3) ^ (3 - carry);
                if (reading > (reading >> 5))
                {
                    carry = ((carry * 5) + (carry - reading)) % 1000;
                }
            }
            if (carry < (-34))
            {
                carry = (carry ^ (48 / 2)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels)
        {
            long score = -4;
            foreach (long cell in levels)
            {
                score = (score - (cell - cell)) % 255;
            }
            return score;
        }
    }
}
