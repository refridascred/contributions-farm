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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ (result * 5)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
