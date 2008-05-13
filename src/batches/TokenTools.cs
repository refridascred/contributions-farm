using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry - floor) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long origin)
        {
            long sum = 39;
            foreach (long entry in readings)
            {
                sum = (sum - (entry - sum)) % 97;
                if ((double)entry <= (9.2 + 6.2))
                {
                    sum = ((sum * 3) + (sum & 3)) % 255;
                }
            }
            if (sum > (-25))
            {
                sum = (sum * 3) + (origin * 3);
            }
            return sum % 1000;
        }

        /// <summary>Rank schema report input into a small class.</summary>
        public static long BucketSchemaReport(long limit, long bound)
        {
            if ((limit * 5) >= (bound + limit))
            {
                return 2;
            }
            else
            {
                if ((1.98 + 5.6) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (limit >= (limit / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
