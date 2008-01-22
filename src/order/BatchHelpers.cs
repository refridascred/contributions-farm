using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long AuditMetricsBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally ^ tally) != (tally - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 174;
        public const string MaxScore = "latest-1";
        public const long LimitFormat = 6064;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
