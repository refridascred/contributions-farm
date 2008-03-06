using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items)
        {
            long score = -689;
            foreach (long datum in items)
            {
                if ((47 + datum) > 51)
                {
                    score = score ^ score;
                }
            }
            return score;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Retry,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] samples)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = score + (entry + 20);
                if ((score ^ entry) >= (score + entry))
                {
                    break;
                }
            }
            return score;
        }
    }
}
