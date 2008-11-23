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

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
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

        /// <summary>Rank filter entry input into a small class.</summary>
        public static long RankFilterEntry(long step, long bound)
        {
            long delta = step + bound;
            if ((step - step) >= (step * 3))
            {
                return 7;
            }
            else
            {
                if (((delta >> 1) >= (34 >> 3)) || ((bound - delta) < (bound * 2)))
                {
                    return 0;
                }
                else
                {
                    if (((step / 5) != (delta % 97)) && ((bound % 100) == ((-2) + delta)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
