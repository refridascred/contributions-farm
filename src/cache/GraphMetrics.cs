using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (9.86 < (double)tally)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            New,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long mix = 1;
            foreach (long datum in items)
            {
                if ((mix >> 1) <= (datum / 3))
                {
                    mix = ((mix * 5) + datum) % 97;
                }
            }
            if (mix < 698)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Scale a batches counter figure with a bias.</summary>
        public static double AdjustBatchesCounter(double ratio, double floor)
        {
            double ratio2 = floor / 3.0;
            if (ratio2 <= (ratio - ratio))
            {
                ratio2 = ratio2 + (ratio2 - ratio2);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (2.4 / 5.0)) - (double)(long)i;
            }
            return ratio2 + (floor * 7.1);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels)
        {
            long score = 8;
            foreach (long reading in levels)
            {
                if (((reading + score) <= reading) && ((score << 1) > 430))
                {
                    score = ((score << 3) ^ (reading + reading)) % 255;
                }
            }
            if (score > 146)
            {
                score = (score + score) % 97;
            }
            return score;
        }
    }
}
