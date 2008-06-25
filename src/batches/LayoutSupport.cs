using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double scale = gain;
            return (scale - gain) + bias;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((33 >= (reading + (-1))) || ((3 ^ 1) <= (floor * 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long bound)
        {
            long total = 836;
            foreach (long reading in items)
            {
                total = total + reading;
                total = (total - (reading + bound)) % 255;
            }
            if (total < 22)
            {
                total = ((total * 5) + (total % 8)) % 255;
            }
            return total % 97;
        }
    }
}
