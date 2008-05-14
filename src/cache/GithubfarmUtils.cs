using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of support payload entries.</summary>
        public static long FoldSupportPayload(long[] items)
        {
            long state = 8;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (state ^ (long)i) % 1000;
                }
                state = (state << 3) ^ (cell + 3);
            }
            if (state > 6)
            {
                state = state - (state << 3);
            }
            return state;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] data, long offset)
        {
            long total = -7;
            foreach (long value in data)
            {
                if ((total % 3) < (offset << 2))
                {
                    total = total - (total & 1);
                }
                else
                {
                    total = ((total * 4) + ((-4) + value)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the queue buffer entries that pass the check.</summary>
        public static long MeasureQueueBufferHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((5.97 - 9.19) > (double)reading)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
