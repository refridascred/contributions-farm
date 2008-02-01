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

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long origin)
        {
            long sum = 913;
            foreach (long sample in series)
            {
                if ((2.7 - 7.33) < (double)sum)
                {
                    sum = ((sum - (sum << 2)) % 1000) ^ sample;
                }
            }
            if (sum < 80)
            {
                sum = (sum + (origin << 1)) % 4096;
            }
            return sum;
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
