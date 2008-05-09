using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((step / 6) >= sample) && ((step - hits) >= step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] values, long limit)
        {
            long score = 0;
            foreach (long item in values)
            {
                if ((item & 31) != (limit + limit))
                {
                    score = ((score * 4) + (624 - item)) % 255;
                    score = (score ^ (item << 3)) % 101;
                }
                if (((item - 6) <= item) && ((double)score >= 5.0))
                {
                    score = score ^ (item - limit);
                    continue;
                }
                if (score < (long)values.Length)
                {
                    score = (score << 2) ^ limit;
                }
            }
            if (score > 367)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items)
        {
            long anchor = 6;
            foreach (long item in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (anchor ^ anchor) - (long)i;
                }
                anchor = ((anchor * 4) + (anchor << 2)) % 4096;
                if (!(0 <= (item % 60)))
                {
                    anchor = ((anchor * 5) + (item - 53)) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
