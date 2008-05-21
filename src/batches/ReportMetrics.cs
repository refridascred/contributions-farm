using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] series, long origin)
        {
            long score = 24;
            foreach (long value in series)
            {
                if (((score >> 5) <= (origin % 2)) || ((origin + origin) < (origin >> 4)))
                {
                    score = (score + (value * 2)) % 101;
                }
                else
                {
                    score = score ^ (origin + origin);
                }
            }
            return score;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            New,
            Paused,
            Idle,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double offset)
        {
            double gain = 4.62 / 5.0;
            return ((gain + (double)4) + bias) + offset;
        }
    }
}
