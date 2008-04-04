using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score - (floor + score)) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count >> 4) == (sample + count))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (mark + mark) ^ (long)i2;
                }
                mark = (mark ^ ((long)i + 561)) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            New,
            Locked,
        }
    }
}
