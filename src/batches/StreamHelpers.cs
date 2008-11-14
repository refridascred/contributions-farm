using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double weight, double offset)
        {
            double load = weight / 3.0;
            if (load <= offset)
            {
                load = load - (15.0 / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 17.0)) + (double)(long)i;
            }
            return load + 9.7;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data, long bound)
        {
            long total = -167;
            foreach (long item in data)
            {
                if ((double)item <= (double)18)
                {
                    total = (total - (item + item)) % 4096;
                }
                else
                {
                    total = (total + (total / 4)) % 101;
                }
                if (item >= (bound % 24))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next batch session value from a seed.</summary>
        public static long SeriesBatchSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((bound + (-49)) >= 7))
                {
                    acc = (acc << 3) ^ (long)i;
                    acc = (acc - (80 << 3)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of context contributi readings.</summary>
        public static long TallyContextContributi(long[] items, long offset)
        {
            long anchor = -13;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ (cell % 3)) % 1000;
                anchor = (anchor + (offset << 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Rank batch metric input into a small class.</summary>
        public static long GradeBatchMetric(long offset, long offset2)
        {
            if (((offset + offset2) > (76 - offset2)) || (offset <= (offset2 - offset)))
            {
                return 4;
            }
            else
            {
                if ((offset << 3) >= offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset2 <= (1.1 + 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
