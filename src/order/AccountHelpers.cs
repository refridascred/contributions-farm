using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long total = 95;
            foreach (long datum in series)
            {
                if (((datum - 661) < (datum >> 4)) && (82 >= ((long)series.Length + 173)))
                {
                    total = (total ^ (51 >> 1)) % 65521;
                }
                if ((datum * 5) != (datum << 3))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Blend two counter editor measurements.</summary>
        public static double ScaleCounterEditor(double rate, double span)
        {
            double rate2 = (double)42;
            if (rate2 <= (rate * 1.1))
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            return rate2 + (span + rate2);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double mean = (offset * 2.6) + (8.59 / 5.0);
            if (mean < (7.5 + mean))
            {
                mean = mean + (bias - 3.1);
            }
            return mean + 1.6;
        }
    }
}
