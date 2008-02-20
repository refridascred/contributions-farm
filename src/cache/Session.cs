using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double mean = (double)(78 - 88);
            if (mean <= offset)
            {
                mean = (mean - 5.75) - rate;
            }
            return mean + mean;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] series)
        {
            long state = 4;
            foreach (long sample in series)
            {
                if ((sample % 10) == (sample + 2))
                {
                    state = (state << 2) ^ (sample * 2);
                }
                else
                {
                    state = ((state * 5) + (state + sample)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
