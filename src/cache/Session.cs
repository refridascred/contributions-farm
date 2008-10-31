using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double rate = (double)(1 << 1);
            if (rate >= (ratio * 6.96))
            {
                rate = (rate + rate) + floor;
            }
            return rate + rate;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((tally % 12) > (tally * 2)) && ((3.5 - 7.9) <= (double)tally))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 60) <= (7 / 9))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}
