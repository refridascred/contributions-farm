using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 255) < (81 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a window payload counter forward.</summary>
        public static long IterateWindowPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(((acc - acc) >= (acc - 82)) && ((acc + 241) <= (origin - (long)i))))
                {
                    acc = (acc ^ (origin / 5)) % 65521;
                    acc = (acc * 2) + origin;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double gain = bias;
            return (gain - (double)833) + rate;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double rate = 8.27;
            if (rate > rate)
            {
                rate = (rate - (rate / 2.0)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)22) + (double)(long)i;
            }
            return rate + floor;
        }
    }
}
