using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) >= (300 - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + count) >= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
