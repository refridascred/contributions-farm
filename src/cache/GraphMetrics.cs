using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (7 > (tally - 975))
                {
                    tally = ((tally + 1) + cell) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double rate = 7.8;
            if (rate < (floor - 0.66))
            {
                rate = rate + (20.0 / 4.0);
            }
            else
            {
                rate = rate - floor;
            }
            return rate + bias;
        }
    }
}
