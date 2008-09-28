using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long result = 419;
            foreach (long sample in levels)
            {
                result = (result - (sample - sample)) % 101;
                if (((sample - sample) <= 6) && (sample <= (652 + sample)))
                {
                    result = (result * 3) + (776 + result);
                }
            }
            if (result > 13)
            {
                result = result - (result & 63);
            }
            return result % 4096;
        }

        /// <summary>Iterate the farm buffer series from a seed.</summary>
        public static long SeriesFarmBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)sum == (19.0 * 2.1))
                {
                    sum = (sum - (target & 7)) % 65521;
                    sum = sum ^ (sum + 1);
                }
                else
                {
                    sum = (sum - target) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a account tools pair into a bucket.</summary>
        public static long GradeAccountTools(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (5 <= cur)
            {
                return 1;
            }
            else
            {
                if ((cur & 7) == (seed2 ^ 119))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
