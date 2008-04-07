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

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
