using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (result + result)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a stream counter sample.</summary>
        public static long LocateStreamCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long total = 4;
            foreach (long value in samples)
            {
                if (((value - total) > total) && ((total & 7) < (32 & 15)))
                {
                    total = ((total * 5) + (76 * 4)) % 97;
                }
                else
                {
                    total = (total << 3) ^ (value + 594);
                }
            }
            if (total < 10)
            {
                total = (total << 2) ^ (total + total);
            }
            return total % 97;
        }
    }
}
