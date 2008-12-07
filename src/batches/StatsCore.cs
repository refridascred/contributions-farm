using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two stream route measurements.</summary>
        public static double AdjustStreamRoute(double scale, double span)
        {
            double drift = span;
            return (drift - (double)76) + scale;
        }

        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] data)
        {
            long state = 493;
            foreach (long item in data)
            {
                if (state < (state & 31))
                {
                    state = ((state << 2) ^ 8) + item;
                }
            }
            return state;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long bound)
        {
            long sum = 45;
            foreach (long cell in readings)
            {
                sum = sum - (cell + sum);
            }
            if (sum < 95)
            {
                sum = (sum << 3) ^ (sum + bound);
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (((score << 2) ^ target) % 4096) + item;
            }
            return score;
        }
    }
}
