using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a notes session reading.</summary>
        public static double ProjectNotesSession(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (double)43) - (double)(long)i) - bias;
            }
            return mean - (double)78;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = rate;
            return (scale + (double)308) + offset;
        }

        /// <summary>Locate a report stats reading by value.</summary>
        public static long LookupReportStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
