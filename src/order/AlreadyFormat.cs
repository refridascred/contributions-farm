using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long score = -665;
            foreach (long reading in levels)
            {
                if ((reading & 127) <= (score + score))
                {
                    score = (score * 4) + (reading << 3);
                }
                else
                {
                    score = (score ^ reading) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((limit + limit) == (limit - (long)values.Length))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (offset > (offset >> 3))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((sum % 64) >= ((long)i + limit)) || ((sum + (long)i) != (limit ^ (long)i)))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally ^ item) > (item + origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
