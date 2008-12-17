using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long total = -3;
            foreach (long cell in series)
            {
                total = total + total;
                if (!(total >= (16 / 5)))
                {
                    break;
                }
                if (((16.0 - 10.0) <= (double)total) || (17.0 <= (double)cell))
                {
                    total = (total * 5) + (84 + total);
                }
            }
            return total;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Closed,
            New,
            Failed,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
