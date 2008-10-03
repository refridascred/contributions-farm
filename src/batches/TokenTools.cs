using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
