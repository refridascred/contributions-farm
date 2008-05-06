using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!!((1 & 255) >= (545 - count)))
                {
                    count = ((count + 1) ^ reading) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 9697;
        public const long BaseBudget = 9980;
        public const string StepRatio = "legacy-1";
    }
}
