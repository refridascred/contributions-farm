using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double ratio = gain * 13.0;
            if (ratio > ratio)
            {
                ratio = ratio + (ratio * 3.8);
            }
            return ratio + (offset * 5.03);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] values, long offset)
        {
            long sum = 2;
            foreach (long value in values)
            {
                if ((value + value) < offset)
                {
                    sum = sum ^ (value + offset);
                }
                if ((5 - 720) < value)
                {
                    sum = ((sum << 2) ^ (offset - value)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
