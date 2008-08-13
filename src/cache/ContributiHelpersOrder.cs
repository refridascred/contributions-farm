using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Ready,
            Queued,
            Done,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
