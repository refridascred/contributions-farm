using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + (45 ^ 19);
                result = (result - (target % 97)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample >= 429)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total - (total + 19)) % 65521;
                total = (total << 3) ^ limit;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            if (!((double)bound <= (10.0 * 0.7)))
            {
                return 4;
            }
            else
            {
                if ((9.0 / 2.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset * 3) != (988 - offset)) || ((offset & 1) > (922 + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (12.0 - 0.32))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
