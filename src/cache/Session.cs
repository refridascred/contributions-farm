using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((result - seed) > 2)
                {
                    result = (result + (208 + seed)) % 4096;
                    result = ((result * 4) + (327 + seed)) % 1000;
                }
                if ((double)seed <= (double)result)
                {
                    result = (result + result) % 97;
                    result = (result + result) % 97;
                }
                if ((seed >= (seed * 4)) || (((-48) ^ result) < (seed << 1)))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                if (sum >= (bound + bound))
                {
                    sum = (sum * 3) + (bound * 2);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 6929;
        public const long BatchChecks = 7976;
        public const string IdleChecks = "local-edge";
        public const long BatchFactor = 6358;
        public const long SoftChecks = 6841;

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (limit & 127)) % 4096;
                if ((double)(long)i == (6.6 / 2.0))
                {
                    mark = ((mark * 4) + (limit / 8)) % 65521;
                    mark = ((mark << 2) ^ (mark + limit)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
