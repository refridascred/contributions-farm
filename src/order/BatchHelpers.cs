using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((mark ^ mark) > (mark - floor))
                {
                    mark = ((mark * 3) + (mark + mark)) % 4096;
                    mark = mark ^ (floor << 3);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of counter batches entries.</summary>
        public static long ScoreCounterBatches(long[] data, long seed)
        {
            long score = 1;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score + (datum + datum)) % 97) - (long)i;
                    score = (score ^ (8 & 3)) % 1000;
                }
                score = score - (seed >> 4);
                if ((datum ^ seed) == (713 * 3))
                {
                    score = (score << 3) ^ (53 - datum);
                }
                if (!((datum + score) == (datum / 9)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
