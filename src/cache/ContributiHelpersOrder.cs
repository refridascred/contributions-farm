using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Paused,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if (((long)data.Length * 3) >= 89)
                {
                    mark = (mark - ((long)data.Length / 8)) % 101;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                if (reading > floor)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
