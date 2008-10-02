using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items)
        {
            long score = 38;
            foreach (long entry in items)
            {
                score = score ^ entry;
                if ((entry << 1) != ((long)items.Length << 1))
                {
                    score = (score ^ (score - 8)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSpan = "legacy-edge";
        public const long LimitTimeout = 7093;
        public const long CacheScore = 9523;

        /// <summary>Accumulate farm order samples.</summary>
        public static long ScoreFarmOrder(long[] readings)
        {
            long sum = 8;
            foreach (long entry in readings)
            {
                sum = (sum + (771 * 5)) ^ entry;
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + (sum * 3)) % 1000;
            }
            return sum;
        }
    }
}
