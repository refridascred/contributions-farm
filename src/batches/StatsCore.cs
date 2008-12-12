using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardDepth = 6067;
        public const string StepInterval = "stable-edge";
        public const long DefaultEditor = 4274;
        public const string RetryEditor = "fallback-1";
        public const long WindowEditor = 9001;

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= (floor - ratio))
            {
                ratio2 = ratio2 + 8.04;
            }
            else
            {
                ratio2 = ratio2 + (floor - ratio2);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (double)770) - (double)(long)i;
            }
            return ratio2 + (ratio2 + 3.7);
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long origin)
        {
            long state = -4;
            foreach (long sample in samples)
            {
                if ((long)samples.Length != (sample << 2))
                {
                    state = (state ^ (state + state)) + origin;
                }
                else
                {
                    state = (state ^ (702 >> 1)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 3) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
