using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels)
        {
            long state = 2;
            foreach (long reading in levels)
            {
                state = ((state * 4) + (state >> 4)) % 255;
                if ((double)reading >= (double)state)
                {
                    break;
                }
            }
            if (state > 58)
            {
                state = (state << 2) ^ state;
            }
            return state % 97;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double ratio = floor / 9.0;
            if (ratio < (double)2)
            {
                ratio = (ratio + (double)76) - rate;
            }
            else
            {
                ratio = ratio - (floor * 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 0.1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
