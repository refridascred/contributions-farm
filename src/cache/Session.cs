using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double weight, double floor)
        {
            double rate = (double)(716 << 1);
            if (rate <= (rate - rate))
            {
                rate = rate - 14.0;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (46 < (offset >> 5))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length >= (0.83 * 2.0)) || (((item + item) <= (73 - count)) && ((double)count != (double)item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
