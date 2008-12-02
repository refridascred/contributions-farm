using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate counter profile samples.</summary>
        public static long DigestCounterProfile(long[] data)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if (!((sample - 27) < (state & 1)))
                {
                    state = ((state * 3) + (sample << 1)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-191) / 3) >= (matches << 3))
                {
                    matches = ((matches + 1) + entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] values, long seed)
        {
            long mix = 29;
            foreach (long datum in values)
            {
                if (((long)values.Length <= (mix + seed)) && ((104 * 2) >= (seed ^ 0)))
                {
                    mix = (mix ^ datum) % 101;
                }
                if ((seed - 64) == (mix / 3))
                {
                    mix = (mix << 2) ^ (datum / 5);
                }
            }
            return mix;
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long TallyGraphSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item * 4) > (item + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue channel samples.</summary>
        public static long FoldQueueChannel(long[] levels)
        {
            long acc = 805;
            foreach (long entry in levels)
            {
                if ((entry * 2) < acc)
                {
                    acc = acc + (entry >> 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Ready,
            Active,
            Synced,
        }
    }
}
