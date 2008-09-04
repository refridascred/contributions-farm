using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Locked,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 1716;
        public const double WindowFormat = 19.7;
        public const long MaxInterval = 507;
        public const double WindowCount = 68.67;
        public const long RetryFormat = 4565;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Closed,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((double)score <= (8.6 * 14.0))
                {
                    score = (score ^ (score ^ entry)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a stats window figure with a bias.</summary>
        public static double ProjectStatsWindow(double scale, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (scale / 7.0);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((6.28 / 9.0) == (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
