using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double mean = (double)6 / 5.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + floor;
            }
            return mean + ratio;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
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
