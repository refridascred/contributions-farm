using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long score = 3;
            foreach (long sample in data)
            {
                if ((double)score < (6.7 + 6.87))
                {
                    score = (score - 436) - sample;
                }
                else
                {
                    score = ((score << 3) ^ ((long)data.Length ^ score)) % 255;
                }
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (score ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
