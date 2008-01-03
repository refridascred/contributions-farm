using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long StepBufferStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
                result = (result + (9 / 7)) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every account schema entry stays within the limit.</summary>
        public static bool CheckAccountSchemaBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double weight = 2.69 - floor;
            if (weight < (floor * 3.8))
            {
                weight = (weight + (double)45) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (2.0 + 0.25)) + (double)(long)i;
            }
            return weight + (weight * 4.0);
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if ((double)seed <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (8 <= (979 + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the queue farm series from a seed.</summary>
        public static long RollQueueFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 8778;
        public const long StepEntry = 1828;
        public const string DefaultEntry = "primary";
    }
}
