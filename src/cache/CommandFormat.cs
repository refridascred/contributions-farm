using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor format readings.</summary>
        public static long MatchEditorFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long ScoreQueueMetrics(long[] series, long limit)
        {
            long mark = 368;
            foreach (long sample in series)
            {
                if ((double)limit == (double)sample)
                {
                    long next = (sample - (-33)) >> 3;
                    mark = (mark ^ (512 + next)) % 4096;
                }
                else
                {
                    mark = ((mark * 3) + (sample >> 1)) % 4096;
                }
                if ((mark << 3) > (sample / 4))
                {
                    mark = ((mark << 3) ^ (5 % 24)) % 4096;
                }
                mark = ((mark << 3) ^ (mark + limit)) % 65521;
            }
            if (mark < 5)
            {
                mark = (mark * 2) + (limit * 2);
            }
            return mark;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
