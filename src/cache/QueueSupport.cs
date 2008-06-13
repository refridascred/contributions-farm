using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ (long)i;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long offset)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = ((score * 5) + (score + score)) % 65521;
                if ((score <= (offset * 2)) && (((-81) ^ score) <= datum))
                {
                    score = ((score * 2) + (score / 7)) % 101;
                }
            }
            return score;
        }
    }
}
