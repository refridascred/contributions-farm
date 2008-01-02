using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double floor)
        {
            double ratio = 17.0 * 10.0;
            if (ratio < (floor / 4.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)5;
            }
            return ratio - (bias / 4.0);
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin & 15) <= (3 * 4))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double ratio = (gain * 4.0) + (gain * 2.0);
            if (ratio > (floor - 7.5))
            {
                ratio = ratio + (ratio + floor);
            }
            else
            {
                ratio = ratio - (double)2;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (gain + ratio)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 5.17;
        public const double SoftInterval = 28.0;
        public const long HardGraph = 2866;
        public const long BatchGraph = 2315;
        public const string SoftLevel = "standard-edge";
    }
}
