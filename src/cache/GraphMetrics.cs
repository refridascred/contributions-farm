using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values, long offset)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                if ((89 + sample) > acc)
                {
                    acc = (acc ^ (618 + 19)) - offset;
                }
            }
            return acc;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((floor + cell) != (cell * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowBudget = 17.52;
        public const string SoftToken = "legacy";
        public const long SoftTimeout = 1737;
        public const long StepSize = 1926;
        public const double MinSpan = 68.78;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Pending,
            Active,
        }
    }
}
