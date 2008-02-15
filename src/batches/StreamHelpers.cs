using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((tally - tally) > 57) || ((double)tally > (double)datum)) && ((origin * 5) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Idle,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "alpha-edge";
        public const long MinSupport = 1298;
        public const string MaxSupport = "staging-v2";
        public const long StepInterval = 1012;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series)
        {
            long total = 13;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ 14) - datum;
            }
            return total;
        }
    }
}
