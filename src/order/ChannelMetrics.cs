using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long score = 8;
            foreach (long reading in items)
            {
                score = ((score - (score & 1)) % 1000) + reading;
            }
            if (score < (-5))
            {
                score = (score - score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Synced,
            Locked,
            Dropped,
            New,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double scale, double floor)
        {
            double rate = floor * 4.9;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (floor / 6.0)) + (double)(long)i) - scale;
            }
            return rate + rate;
        }
    }
}
