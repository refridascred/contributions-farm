using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a stats already counter forward.</summary>
        public static long RollStatsAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 2) ^ carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (ratio * 1.9))
            {
                ratio = ratio + (weight * 7.8);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)88) + (double)(long)i;
            }
            return ratio - (bias * 9.49);
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double scale = (double)(6 + (-2));
            if (scale <= scale)
            {
                scale = ((scale + 12.0) - bias) - offset;
            }
            else
            {
                scale = scale + 8.4;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)58) + (double)(long)i;
            }
            return scale - (double)(-758);
        }
    }
}
