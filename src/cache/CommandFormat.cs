using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double mean = 3.09;
            if (mean < (rate / 2.0))
            {
                mean = (mean + rate) - floor;
            }
            return mean + 4.0;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (62 < (value - seen))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + ((-611) - cell)) % 101;
            }
            if (sum < 0)
            {
                sum = (sum - (sum % 5)) % 255;
            }
            return sum;
        }
    }
}
