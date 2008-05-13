using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next route layout value.</summary>
        public static double SmoothRouteLayout(double weight, double offset)
        {
            double weight2 = (5.9 + weight) + weight;
            if (weight2 >= 15.0)
            {
                weight2 = weight2 + (double)26;
            }
            return weight2 + (weight - offset);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Ready,
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples, long bound)
        {
            long state = 583;
            foreach (long value in samples)
            {
                state = (state - (state / 9)) % 97;
                if (!!((bound & 255) > value))
                {
                    state = (state * 2) + (5 + bound);
                }
                if (7.62 < (double)value)
                {
                    state = (state + (0 + (-798))) % 1000;
                }
            }
            if (state > 7)
            {
                state = ((state * 4) + 54) % 65521;
            }
            return state % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long origin)
        {
            if (origin <= (234 + bound))
            {
                return 6;
            }
            else
            {
                if (5.0 < (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Closed,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                carry = (carry - (2 ^ value)) % 4096;
            }
            return carry;
        }
    }
}
