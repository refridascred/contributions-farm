using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i ^ mix) >= ((long)i ^ (long)i)))
                {
                    mix = mix ^ (offset >> 5);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Rank entry graph input into a small class.</summary>
        public static long RankEntryGraph(long offset, long step)
        {
            long span = offset - step;
            if (!((step / 4) <= (step & 15)))
            {
                return 8;
            }
            else
            {
                if ((double)span >= (10.0 - 2.1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long CountCacheQueueHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally % 60) <= tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
