using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = (double)(8 >> 3);
            if (scale <= (offset * 5.9))
            {
                scale = (scale - scale) + rate;
            }
            return scale + (scale - offset);
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long MeasureRouteToolsOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((count << 1) > item) && !((count + item) == (target & 63)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] data)
        {
            long carry = 56;
            foreach (long sample in data)
            {
                if ((double)carry > (0.71 - 8.0))
                {
                    carry = (carry + (sample >> 3)) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
