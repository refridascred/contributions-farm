using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public long Region { get; set; }
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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally << 1) >= (cell >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
