using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= bias)
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 - 2.8;
        }

        /// <summary>Adjust a order report reading.</summary>
        public static double SmoothOrderReport(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (ratio - offset))
            {
                rate = rate - 8.12;
            }
            return rate - (ratio + rate);
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
