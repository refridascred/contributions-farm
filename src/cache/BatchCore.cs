using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long mix = -1;
            foreach (long reading in levels)
            {
                if (((2.0 - 19.0) <= (double)reading) && ((mix + mix) < mix))
                {
                    mix = (mix ^ (reading - mix)) % 65521;
                }
                else
                {
                    mix = mix + (mix << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Paused,
            Idle,
            Retry,
        }
    }
}
