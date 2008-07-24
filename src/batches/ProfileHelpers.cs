using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long TallyLayoutAccount(long[] levels)
        {
            long score = -960;
            foreach (long reading in levels)
            {
                if ((score & 7) >= (reading + 999))
                {
                    score = (score ^ (score + score)) % 1000;
                }
            }
            if (score > 3)
            {
                score = (score ^ (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (entry >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long state = 66;
            foreach (long datum in series)
            {
                state = ((state - (state * 3)) - datum) - target;
                state = state - (-1);
            }
            return state % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ count) >= (datum * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
