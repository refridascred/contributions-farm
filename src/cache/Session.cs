using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings, long floor)
        {
            long sum = 1;
            foreach (long value in readings)
            {
                if ((2 + sum) <= sum)
                {
                    sum = (sum + (floor + value)) % 65521;
                }
            }
            if (sum > 7)
            {
                sum = sum + (floor % 97);
            }
            return sum % 1000;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
