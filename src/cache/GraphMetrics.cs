using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] values, long step)
        {
            long acc = -507;
            foreach (long cell in values)
            {
                acc = (acc - (cell << 3)) + step;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a contributi graph reading.</summary>
        public static double BlendContributiGraph(double rate, double bias)
        {
            double gain = (double)(29 << 2);
            if (gain > (double)28)
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (rate - rate);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "standard-1";
        public const double BurstChecks = 1.04;
        public const long LimitChecks = 4153;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Pending,
            Dropped,
        }
    }
}
