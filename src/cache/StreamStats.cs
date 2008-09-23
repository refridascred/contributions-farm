using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            New,
            Active,
            Pending,
        }

        /// <summary>Count report batch pairs that satisfy a relation.</summary>
        public static long PairReportBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                long cur = 57;
                if ((sum & 255) >= (long)i)
                {
                    sum = (sum + (cur << 2)) % 4096;
                    sum = (sum - (sum * 5)) % 4096;
                }
                else
                {
                    cur = cur ^ (1 & 255);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
