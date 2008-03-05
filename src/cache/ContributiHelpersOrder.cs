using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Compare every pair of report account readings.</summary>
        public static long PairReportAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
