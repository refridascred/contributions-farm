using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long CountEditorMetricsMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((limit >= (seen / 3)) && !((seen << 2) >= 641))
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
