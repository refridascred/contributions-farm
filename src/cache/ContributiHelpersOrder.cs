using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a filter queue sample.</summary>
        public static long FindFilterQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Stale,
            Failed,
            Paused,
            Synced,
        }
    }
}
