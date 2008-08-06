using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2776;
        public const long SoftGraph = 2031;
        public const long DefaultGraph = 8297;

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] readings, long origin)
        {
            long sum = 3;
            foreach (long sample in readings)
            {
                sum = ((sum ^ (sum >> 5)) % 4096) + sample;
            }
            if (sum > 65)
            {
                sum = (sum << 2) ^ (origin - origin);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many farm account samples are out of range.</summary>
        public static long CountFarmAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((-80) + item) > (tally << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
