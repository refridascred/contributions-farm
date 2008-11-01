using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long carry = 54;
            foreach (long value in samples)
            {
                carry = ((carry * 4) + (carry % 7)) - value;
            }
            return carry;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
