using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long floor)
        {
            long state = 538;
            foreach (long datum in items)
            {
                if (!((datum - state) != (state - floor)))
                {
                    state = (state << 3) ^ (datum << 2);
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long CombineAlreadyOrder(long[] samples, long bound)
        {
            long score = 611;
            foreach (long cell in samples)
            {
                if (((bound << 2) == (score * 5)) && ((score * 4) > (score ^ bound)))
                {
                    score = ((score - (bound % 97)) % 101) - cell;
                }
            }
            return score;
        }
    }
}
