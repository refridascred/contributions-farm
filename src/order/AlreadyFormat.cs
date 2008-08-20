using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Ready,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Combine channel contributi values into a single score.</summary>
        public static long TallyChannelContributi(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = ((acc - (-80)) % 101) - entry;
            }
            return acc;
        }

        /// <summary>Count the metric stream entries that pass the check.</summary>
        public static long TallyMetricStreamMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally <= 6.26)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
