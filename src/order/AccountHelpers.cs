using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a route notes reading by value.</summary>
        public static long LookupRouteNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((9.8 + 1.6) >= (double)seen) && (origin <= (origin << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Failed,
            New,
        }

        /// <summary>Count the layout farm entries that pass the check.</summary>
        public static long TallyLayoutFarmGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally + reading) >= (7 + 56)))
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double scale = weight;
            if (scale < (offset / 5.0))
            {
                scale = scale - (double)882;
            }
            return scale - (double)584;
        }

        /// <summary>Count stats route pairs that satisfy a relation.</summary>
        public static long OverlapStatsRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
