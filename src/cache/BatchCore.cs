using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of route report entries.</summary>
        public static long WeighRouteReport(long[] levels)
        {
            long carry = -11;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + (item + 927)) % 65521;
                carry = (carry << 3) ^ (item % 64);
                carry = carry ^ (long)levels.Length;
            }
            if (carry < 534)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long MeasureMetricsGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + matches) <= (matches ^ (long)samples.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Closed,
            Active,
            Pending,
        }
    }
}
