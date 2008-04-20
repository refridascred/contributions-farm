using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of schema farm readings.</summary>
        public static long MatchSchemaFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
