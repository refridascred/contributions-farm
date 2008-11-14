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

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 7744;
        public const long WindowStream = 2849;
        public const long CacheScore = 1984;
        public const long MaxWidth = 3495;
        public const long CacheStream = 9326;

        /// <summary>Derive the next cluster command value from a seed.</summary>
        public static long DeriveClusterCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (seed / 4)) % 101;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
