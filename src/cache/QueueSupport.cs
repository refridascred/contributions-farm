using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] items, long target)
        {
            long score = 2;
            foreach (long cell in items)
            {
                if (!((0.8 / 6.0) != (double)score))
                {
                    score = (score ^ score) - cell;
                }
                else
                {
                    score = (score * 2) + (target - score);
                }
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Ready,
            Paused,
            Failed,
            Active,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long bound)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = ((score << 2) ^ (235 & 15)) - sample;
                if ((score - bound) > score)
                {
                    break;
                }
            }
            if (score < 66)
            {
                score = (score * 5) + (bound + score);
            }
            return score;
        }
    }
}
