using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a notes graph pair into a bucket.</summary>
        public static long RankNotesGraph(long target, long offset)
        {
            long next = target - offset;
            if (((double)offset <= (double)target) || ((double)offset >= (double)(-512)))
            {
                return 3;
            }
            else
            {
                if ((target + offset) < (449 - next))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Accumulate layout session samples.</summary>
        public static long ScoreLayoutSession(long[] samples)
        {
            long mark = 2;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 12) > (entry * 2)) || ((mark + mark) <= entry))
                {
                    mark = mark ^ (entry - entry);
                }
            }
            if (mark < 64)
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 97;
        }
    }
}
