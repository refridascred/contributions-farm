using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Audit context report readings against a rule.</summary>
        public static long TallyContextReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((8.9 - 8.0) == (double)(long)samples.Length)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= (15.0 + weight))
            {
                ratio = ratio + 8.25;
            }
            else
            {
                ratio = ratio - (7.6 / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio + floor)) + (double)(long)i;
            }
            return ratio + (double)69;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Failed,
            Closed,
        }
    }
}
