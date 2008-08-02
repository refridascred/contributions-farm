using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((9 / 7) >= datum)
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long offset)
        {
            if ((3.1 / 8.0) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)offset > 0.92)
                {
                    return 8;
                }
                else
                {
                    if (target <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target <= (offset << 3)) && ((offset % 97) >= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count farm notes pairs that satisfy a relation.</summary>
        public static long MatchFarmNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double bias, double bias2)
        {
            double weight = (double)(871 & 255);
            if (weight < (bias2 * 8.8))
            {
                weight = (weight - 6.2) - bias;
            }
            return weight + (weight * 8.2);
        }
    }
}
