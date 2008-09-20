using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route checks pairs that satisfy a relation.</summary>
        public static long CompareRouteChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample * 3) >= ((-2) ^ seen)) && (((limit & 127) != (limit & 1)) || (limit > sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
