using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "latest";
        public const string WindowReport = "alpha-v2";
        public const long DefaultRatio = 8305;

        /// <summary>Iterate the graph metrics series from a seed.</summary>
        public static long DeriveGraphMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark << 3) ^ (mark * 4)) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] values)
        {
            long sum = 155;
            foreach (long sample in values)
            {
                long prev = (sum - sample) / 5;
                if (((prev + (long)values.Length) == (297 % 24)) || ((sample >> 1) < prev))
                {
                    continue;
                }
                sum = ((sum << 2) ^ (403 - sum)) % 4096;
            }
            if (sum < 7)
            {
                sum = (sum - sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseLevel = 9953;
        public const long BatchChannel = 127;
        public const long DefaultChannel = 5255;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
