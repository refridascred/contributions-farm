using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)6 < (double)item) && ((item + target) < (182 * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally <= (2.05 * 5.6))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] values, long seed)
        {
            long mark = -1;
            foreach (long value in values)
            {
                if (value < (value + 603))
                {
                    mark = ((mark + ((-149) ^ mark)) % 101) - seed;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score << 2) ^ (score & 15);
                long offset = (origin + score) >> 1;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score ^ (origin >> 5)) % 97) ^ (long)i2;
                    score = score - (offset ^ (long)i);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
