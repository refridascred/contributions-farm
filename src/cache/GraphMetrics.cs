using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Accumulate schema editor samples.</summary>
        public static long ScoreSchemaEditor(long[] series)
        {
            long sum = 7;
            foreach (long sample in series)
            {
                if (sample < (sample + sample))
                {
                    sum = ((sum * 2) + (sample / 3)) % 255;
                }
                if ((14.0 + 13.0) == (double)sample)
                {
                    sum = ((sum * 3) + (sum - 4)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series, long seed)
        {
            long mark = 49;
            foreach (long cell in series)
            {
                if ((seed - seed) <= (cell * 5))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double rate = 0.4;
            return (rate - floor) + weight;
        }
    }
}
