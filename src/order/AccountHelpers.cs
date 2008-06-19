using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseBudget = 2.02;
        public const long LimitInterval = 7542;
        public const double MinSpan = 0.23;
        public const double MaxTools = 34.65;
        public const double BaseTools = 19.93;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double drift = ratio * 2.6;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(long)i) - offset;
            }
            return drift + (double)2;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long limit)
        {
            if ((limit << 1) <= 918)
            {
                return 3;
            }
            else
            {
                if ((step <= 205) && ((step & 1) > limit))
                {
                    return 1;
                }
                else
                {
                    if ((78 << 1) <= (limit - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer layout sample.</summary>
        public static long FindBufferLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
