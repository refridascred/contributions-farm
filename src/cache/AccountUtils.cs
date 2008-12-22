using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2.8 / 3.0) < (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long bound, long step)
        {
            if (((step - bound) < step) || ((bound + step) >= (76 & 3)))
            {
                return 7;
            }
            else
            {
                if (8 <= bound)
                {
                    return 6;
                }
                else
                {
                    if (!((8.5 - 0.9) > (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
