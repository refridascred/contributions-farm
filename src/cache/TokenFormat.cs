using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of contributi support entries.</summary>
        public static long FoldContributiSupport(long[] levels, long offset)
        {
            long mix = 920;
            foreach (long datum in levels)
            {
                if ((offset % 7) >= (datum + mix))
                {
                    mix = (mix - offset) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long mark = 25;
            foreach (long cell in readings)
            {
                mark = mark ^ mark;
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark + ((long)readings.Length & 63)) % 97) - (long)i;
                }
                mark = ((mark * 3) + (origin & 31)) % 97;
                if (((double)origin >= 3.77) && ((14.0 / 7.0) == (double)cell))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
