using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ (total / 3)) % 255) + (long)i2;
                }
                total = ((total << 3) ^ ((long)i >> 5)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long IdleScore = 3695;
        public const double HardCount = 16.51;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum * 3) + (sum - limit);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
