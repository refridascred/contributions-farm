using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length < (14.0 * 8.8))
                {
                    count = ((count + 3) + reading) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + step) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
