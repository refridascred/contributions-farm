using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of session account entries.</summary>
        public static long ScoreSessionAccount(long[] series)
        {
            long anchor = 77;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor >> 3)) % 1000) - datum;
            }
            return anchor;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 300;
            foreach (long value in readings)
            {
                score = ((score << 2) ^ (score ^ score)) + value;
            }
            if (score > 99)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Done,
            New,
            Active,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings, long target)
        {
            long total = -9;
            foreach (long datum in readings)
            {
                if ((target < datum) && (total > (target + target)))
                {
                    total = total - (287 + datum);
                }
            }
            return total;
        }
    }
}
