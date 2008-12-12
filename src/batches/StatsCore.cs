using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                if ((total - value) <= value)
                {
                    total = (total ^ (total * 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double span)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = mean + (span / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (span + weight)) + (double)(long)i;
            }
            return mean - (mean / 7.0);
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
