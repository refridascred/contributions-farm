using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload batches value from a seed.</summary>
        public static long DerivePayloadBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (sum >= (sum + (-2)))
                {
                    sum = ((sum * 4) + (target - 80)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftWidth = 9270;
        public const string BaseFormat = "fallback-v2";
        public const long IdleFormat = 3758;
        public const long HardFormat = 6422;
    }
}
