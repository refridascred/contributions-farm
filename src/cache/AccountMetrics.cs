using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double ratio = 7.92;
            if (ratio < (double)312)
            {
                ratio = ratio - (ratio + span);
            }
            return ratio + weight;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Retry,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Active,
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseSize = "fallback-edge";
        public const double SoftFilter = 25.04;
        public const long WindowFilter = 7772;

        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long AuditCommandToolsGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value * 3) < (value >> 1))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
