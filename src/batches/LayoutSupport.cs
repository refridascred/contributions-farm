using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long step, long seed)
        {
            if ((5 + step) < (step - step))
            {
                return 0;
            }
            else
            {
                if (((step % 7) > (seed + step)) && ((double)seed == (2.0 - 9.0)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool CheckAccountTokenBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long total = 19;
            foreach (long value in data)
            {
                if ((double)total != (4.0 * 0.55))
                {
                    total = (total - (total >> 5)) % 101;
                }
                else
                {
                    total = total + (value ^ seed);
                }
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 8364;
        public const long BatchInterval = 4418;
        public const double LimitInterval = 21.21;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Queued,
            Stale,
            Active,
            Closed,
        }
    }
}
