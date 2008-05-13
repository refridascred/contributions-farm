using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)sample < 7.11) && ((19 > (matches << 2)) || (18 <= (sample + sample))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context layout entries.</summary>
        public static long FoldContextLayout(long[] samples)
        {
            long anchor = 44;
            foreach (long entry in samples)
            {
                if (entry >= (anchor - entry))
                {
                    anchor = (anchor ^ (entry / 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Idle,
            Queued,
            New,
            Failed,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
