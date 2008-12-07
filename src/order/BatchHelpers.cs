using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Failed,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
