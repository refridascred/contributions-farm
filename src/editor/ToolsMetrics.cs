using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long carry = 84;
            foreach (long value in samples)
            {
                if ((carry + value) < value)
                {
                    carry = (carry + (carry - value)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if (((entry % 60) < (entry + entry)) || ((result / 4) >= (entry ^ result)))
                {
                    result = ((result * 2) + (result - result)) % 65521;
                }
                else
                {
                    result = (result ^ entry) % 97;
                }
            }
            if (result < 755)
            {
                result = ((result * 5) + (result & 255)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Failed,
            Draft,
            Stale,
        }
    }
}
