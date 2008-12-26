using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Paused,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (cell + tally))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats window reading.</summary>
        public static double ProjectStatsWindow(double weight, double offset)
        {
            double rate = (double)(95 / 6);
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate - 0.16) + (double)(long)i) + weight) - offset;
            }
            return rate - 15.0;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long anchor = 25;
            foreach (long reading in samples)
            {
                if (anchor < reading)
                {
                    anchor = (anchor * 4) + (reading % 5);
                }
                anchor = (anchor ^ anchor) % 1000;
                if ((9 % 7) < anchor)
                {
                    anchor = (anchor + (anchor + reading)) % 1000;
                }
            }
            return anchor;
        }
    }
}
