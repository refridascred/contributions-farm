using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long score = 72;
            foreach (long entry in series)
            {
                score = (score * 3) + (entry >> 5);
                if (!((entry ^ score) >= (score ^ entry)))
                {
                    score = (score ^ (score * 2)) % 1000;
                }
                else
                {
                    score = score ^ (48 / 9);
                }
            }
            return score;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
