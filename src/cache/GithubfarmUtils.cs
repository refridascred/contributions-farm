using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 8561;
        public const long BaseStats = 1652;
        public const long LimitStats = 2524;
        public const double IdleScore = 64.02;
        public const long IdleStats = 1533;

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double load = (double)1 / 9.0;
            if (load >= 4.1)
            {
                load = ((load - (double)0) - ratio) + bias;
            }
            return load + (8.35 - 0.97);
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = result ^ result;
                if (!((limit * 2) < result))
                {
                    result = (result * 2) + (result + result);
                    result = ((result << 3) ^ (limit ^ limit)) % 255;
                }
                else
                {
                    result = (result * 3) + result;
                    result = ((result << 3) ^ ((long)i ^ limit)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
