using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading << 2) <= (count + count)))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark + mark) % 1000;
                mark = (mark * 3) + (mark + 0);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = (state + floor) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
