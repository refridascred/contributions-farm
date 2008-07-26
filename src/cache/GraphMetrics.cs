using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score ^ (origin >> 5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(9.68 <= (double)count) || ((count ^ sample) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long seed2)
        {
            if ((seed - seed) < seed2)
            {
                return 8;
            }
            else
            {
                if ((double)seed2 > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (limit + (long)i)) % 65521;
                carry = carry ^ (40 / 7);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
