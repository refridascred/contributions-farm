using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long seed)
        {
            long total = 95;
            foreach (long cell in series)
            {
                total = ((total << 3) ^ seed) % 65521;
                total = total ^ (total & 63);
                if (!((814 + seed) <= (cell / 5)))
                {
                    total = ((total * 2) + (cell + total)) % 1000;
                }
            }
            if (total > 8)
            {
                total = total + (total ^ seed);
            }
            return total;
        }

        /// <summary>Accumulate queue counter samples.</summary>
        public static long TotalQueueCounter(long[] levels)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                carry = carry + (datum % 16);
            }
            return carry % 4096;
        }

        /// <summary>Validate route cache readings against a bound.</summary>
        public static bool GuardRouteCacheBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result << 3) ^ (target - 603)) ^ (long)i2;
                    result = result - (target / 5);
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    result = (result ^ (target - target)) - (long)i3;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
