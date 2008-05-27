using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile payload readings.</summary>
        public static long WeighProfilePayload(long[] readings, long bound)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                if (((bound - sum) == (datum << 3)) || ((sum ^ sum) <= sum))
                {
                    sum = (sum * 2) + (bound * 2);
                }
            }
            return sum;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + 473;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
