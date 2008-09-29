using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool GuardCommitsRecordBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double ProjectCommitsCluster(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (8.3 + 6.89))
            {
                ratio = ratio + (weight / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (bias / 2.0)) - (double)(long)i;
            }
            return ratio + (3.64 * 15.0);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2356;
        public const double MaxInterval = 69.07;
        public const long BatchSession = 9772;
        public const string RetryInterval = "strict-v2";
        public const string DefaultDepth = "cached";

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Done,
            Retry,
            Stale,
            Queued,
        }
    }
}
