using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.0 - 2.0) > (3.0 * 6.1))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster contributi input into a small class.</summary>
        public static long SortClusterContributi(long limit, long step)
        {
            if (step <= limit)
            {
                return 8;
            }
            else
            {
                if ((step + step) == (step / 7))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue route entries that pass the check.</summary>
        public static long TallyQueueRouteGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry & 127))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                long bound = mark;
                if (offset > (bound % 12))
                {
                    mark = mark + (bound & 63);
                    mark = (mark + ((-80) >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
