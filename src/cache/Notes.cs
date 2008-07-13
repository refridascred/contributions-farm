using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) != (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long offset)
        {
            long next = target - offset;
            if (!((offset << 2) <= (target ^ target)))
            {
                return 8;
            }
            else
            {
                if ((target & 7) != (274 + next))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a counter contributi pair into a bucket.</summary>
        public static long SortCounterContributi(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((double)lane != (7.8 + 2.2))
            {
                return 3;
            }
            else
            {
                if ((double)bound2 != (9.0 * 5.25))
                {
                    return 5;
                }
                else
                {
                    if (!((bound2 & 7) >= (bound2 & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)2 < (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Stale,
            Closed,
            Done,
            Failed,
        }
    }
}
