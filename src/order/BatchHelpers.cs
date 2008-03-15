using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next order session value from a seed.</summary>
        public static long StepOrderSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order farm entries.</summary>
        public static long ScoreOrderFarm(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                acc = (acc + (origin / 6)) + entry;
            }
            if (acc > 36)
            {
                acc = acc ^ (5 % 5);
            }
            return acc % 65521;
        }
    }
}
