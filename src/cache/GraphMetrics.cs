using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long origin)
        {
            long prev = step - origin;
            if (step >= (35 % 100))
            {
                return 3;
            }
            else
            {
                if ((double)prev <= (3.3 + 4.25))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = (result - (390 / 8)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels, long step)
        {
            long acc = 680;
            foreach (long datum in levels)
            {
                if (acc < (348 >> 2))
                {
                    acc = ((acc ^ acc) + datum) - step;
                }
            }
            return acc % 97;
        }
    }
}
