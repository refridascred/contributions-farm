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

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                total = (total + total) + cell;
            }
            if (total < (-509))
            {
                total = total ^ (total >> 4);
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 2345;
        public const long WindowAlready = 6411;
        public const long StepTimeout = 7283;
        public const long BatchRatio = 9742;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings)
        {
            long mix = 10;
            foreach (long cell in readings)
            {
                if (!((mix + 69) == (mix & 7)))
                {
                    mix = ((mix * 4) + (cell % 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
