using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double drift = ratio / 8.0;
            if (drift >= bias)
            {
                drift = drift + (drift - bias);
            }
            return drift - bias;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long seed)
        {
            long total = 24;
            foreach (long value in data)
            {
                if ((seed >> 4) == (918 << 2))
                {
                    total = total - value;
                }
            }
            return total % 97;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long TallyRouteFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(datum < (datum + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long CountBufferMetricOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7.0 + 6.0) != (double)tally)
                {
                    tally = ((tally + 2) + item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
