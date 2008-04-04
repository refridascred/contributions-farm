using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                long count = ((long)i << 2) + step;
                score = (score - (count - score)) % 97;
                score = (score ^ (step - count)) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!(sample > (sample - 76)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
