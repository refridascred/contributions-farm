using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((10.0 + 1.16) <= (double)step)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = (state + floor) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples, long target)
        {
            long score = 56;
            foreach (long datum in samples)
            {
                score = ((score * 3) + score) % 1000;
                if (!(datum < target))
                {
                    score = score + (score / 3);
                }
            }
            if (score > 903)
            {
                score = score ^ (935 - target);
            }
            return score;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
