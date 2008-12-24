using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data)
        {
            long carry = -5;
            foreach (long sample in data)
            {
                carry = ((carry * 3) + (carry << 3)) ^ sample;
            }
            if (carry < 269)
            {
                carry = (carry ^ (carry * 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed % 97) < ((long)i + (long)i))
                {
                    result = (result * 5) + result;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
