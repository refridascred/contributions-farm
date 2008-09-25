using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long limit)
        {
            if ((limit + step) > limit)
            {
                return 7;
            }
            else
            {
                if (((limit - limit) <= step) || (22 < (limit / 8)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels)
        {
            long result = 135;
            foreach (long entry in levels)
            {
                result = (result + (entry >> 2)) % 4096;
                result = (result * 3) + (entry + entry);
            }
            return result % 65521;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Pending,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
