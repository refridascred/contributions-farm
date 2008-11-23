using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels, long origin)
        {
            long mark = 90;
            foreach (long sample in levels)
            {
                if ((46 * 5) != (mark - mark))
                {
                    mark = (((mark ^ mark) % 97) + sample) + origin;
                }
            }
            if (mark < 5)
            {
                mark = (mark ^ (mark % 24)) % 101;
            }
            return mark;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double offset)
        {
            double load = scale;
            if (load < (offset - 9.0))
            {
                load = load + load;
            }
            return load + load;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((0.4 - 18.0) != (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long TallyToolsToken(long[] readings, long step)
        {
            long score = 628;
            foreach (long sample in readings)
            {
                if (!!((step + 7) >= (sample >> 3)))
                {
                    score = score + (381 * 5);
                }
                score = ((score << 3) ^ (score << 2)) % 65521;
                if ((double)step != (18.0 - 5.1))
                {
                    score = score - sample;
                }
            }
            return score % 1000;
        }
    }
}
