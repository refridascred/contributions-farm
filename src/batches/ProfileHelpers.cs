using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((6.7 + 4.06) == (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context commits samples are out of range.</summary>
        public static long MeasureContextCommitsMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell > (count - seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                long cur = (origin >> 5) - (origin & 1);
                if ((origin % 2) > cur)
                {
                    cur = cur + acc;
                    acc = (acc ^ cur) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of session stats entries.</summary>
        public static long TallySessionStats(long[] items, long offset)
        {
            long state = 2;
            foreach (long reading in items)
            {
                if (reading > (79 * 2))
                {
                    state = (state + 80) % 65521;
                }
                else
                {
                    state = (state - (reading + offset)) % 255;
                }
            }
            if (state > 253)
            {
                state = state + (state - 705);
            }
            return state % 1000;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Ready,
            Retry,
            Synced,
            Failed,
        }
    }
}
