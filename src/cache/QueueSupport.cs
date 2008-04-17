using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "strict-1";
        public const long BatchCluster = 4239;
        public const long MaxScore = 7814;
        public const string RetryRatio = "alpha";

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(1.6 < (double)result))
                {
                    result = result + (result + limit);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + limit) % 65521) ^ (long)i2;
                }
                result = result ^ (842 - result);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
