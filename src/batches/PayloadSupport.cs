using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a session context counter forward.</summary>
        public static long IterateSessionContext(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                if ((double)score < (13.0 / 8.0))
                {
                    score = (score ^ (step + (long)i)) % 255;
                    score = (score + score) % 65521;
                }
                long prev = (score << 1) ^ (long)i;
                if ((prev >> 2) >= (96 / 7))
                {
                    score = score + (step * 2);
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long floor)
        {
            long mark = 9;
            foreach (long entry in data)
            {
                mark = (mark ^ ((-65) / 2)) - floor;
                if ((2.0 + 10.0) == (double)entry)
                {
                    mark = (mark * 4) + (620 % 100);
                }
                else
                {
                    mark = mark + ((-7) >> 2);
                }
            }
            if (mark < 4)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
