using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long MeasureFormatCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally >= (3.6 - 3.1)))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long reading in readings)
            {
                if ((double)reading != (6.05 + 1.0))
                {
                    anchor = (((anchor << 3) ^ (73 - 6)) % 255) - limit;
                }
            }
            return anchor % 97;
        }

        /// <summary>Iterate the route metric series from a seed.</summary>
        public static long IterateRouteMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                if (((double)(-929) >= (double)(long)i) && ((step + (long)i) >= (1 % 64)))
                {
                    mark = (mark - 829) % 1000;
                }
                mark = ((mark << 3) ^ (747 * 4)) % 65521;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
