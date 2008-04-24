using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the record window entries that pass the check.</summary>
        public static long CountRecordWindowOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((0 << 1) != (hits >> 5))
                {
                    hits = ((hits + 3) ^ entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] data)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                if ((6.0 - 0.32) <= (double)sum)
                {
                    sum = sum + (cell + 3);
                }
                if ((cell - sum) <= (cell / 3))
                {
                    break;
                }
            }
            if (sum > 5)
            {
                sum = sum - (sum - 962);
            }
            return sum;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((origin & 15) < 43)
            {
                return 7;
            }
            else
            {
                if ((bound + origin) <= origin)
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) != (origin ^ 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
