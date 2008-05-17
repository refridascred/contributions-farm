using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches != (5.0 / 2.0))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Done,
            Active,
            Queued,
        }

        /// <summary>Audit buffer filter readings against a rule.</summary>
        public static long TallyBufferFilterGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value / 8) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - mean) - (double)(long)i) + offset;
            }
            return mean + mean;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long step2)
        {
            if ((double)step2 <= 8.2)
            {
                return 8;
            }
            else
            {
                if ((1.06 >= (double)step) && ((step2 * 5) >= (step ^ step2)))
                {
                    return 3;
                }
                else
                {
                    if ((6.8 - 6.7) >= (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(step <= (step + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
