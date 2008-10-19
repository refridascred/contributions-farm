using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (16.0 - 7.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry * 3) + (1 / 9);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double span)
        {
            double bias = weight;
            return bias - (weight + span);
        }
    }
}
