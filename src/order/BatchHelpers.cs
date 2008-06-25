using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of layout entry readings.</summary>
        public static long OverlapLayoutEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Locked,
            Done,
            Failed,
            Paused,
        }
    }
}
