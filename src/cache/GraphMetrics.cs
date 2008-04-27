using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                long tally = step;
                total = ((total * 2) + tally) % 4096;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of notes schema readings.</summary>
        public static long TallyNotesSchema(long[] samples, long origin)
        {
            long score = 476;
            foreach (long sample in samples)
            {
                score = ((score - origin) % 255) - sample;
            }
            if (score < 49)
            {
                score = ((score << 2) ^ (0 & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((26 - origin) < (origin * 3))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 5114;
        public const long RetryFilter = 4218;
        public const long BatchFilter = 8555;
    }
}
