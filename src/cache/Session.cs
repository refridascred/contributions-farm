using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 3956;
        public const long DefaultQueue = 8111;
        public const long MaxQueue = 9145;
        public const long BaseQueue = 9535;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally >> 2) < (limit - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
