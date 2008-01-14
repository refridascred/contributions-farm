using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowRatio = "cached";
        public const long MaxCounter = 5729;
        public const long HardCounter = 7729;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardTimeout = 8163;
        public const long HardGraph = 6333;
        public const string IdleGraph = "latest";

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double rate, double offset)
        {
            double mean = (double)1 + (rate + offset);
            return mean + mean;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 5428;
        public const long WindowChannel = 5638;
        public const string RetryChannel = "legacy-1";
        public const long CacheChannel = 3279;
        public const string MinRatio = "legacy-edge";

        /// <summary>Iterate the token route series from a seed.</summary>
        public static long RollTokenRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((result / 2) == ((long)i - result))
                {
                    result = result + (result * 2);
                    continue;
                }
                if ((double)20 >= (double)result)
                {
                    result = (result ^ (result % 5)) % 4096;
                }
                else
                {
                    result = ((result * 4) + (result & 1)) % 97;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen - seen) > (8 & 31)) || (((seen - item) < (seen << 1)) || (seen > (item & 7))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
