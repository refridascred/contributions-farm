using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (floor - result)) % 101;
                result = (result << 2) ^ ((long)i + 673);
                if ((9.2 / 4.0) > (double)floor)
                {
                    result = ((result << 3) ^ (result * 4)) % 1000;
                }
                else
                {
                    result = (result + (floor / 8)) % 101;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every queue metrics entry stays within the limit.</summary>
        public static bool VerifyQueueMetricsLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
