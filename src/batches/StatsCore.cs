using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Failed,
            Pending,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark - ((long)i + target)) % 1000) ^ (long)i2;
                }
                if ((target > mark) || ((7.5 - 2.0) >= (double)(long)i))
                {
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double load = bias;
            if (load >= gain)
            {
                load = load - bias;
            }
            else
            {
                load = load + (gain * 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)9) + (double)(long)i;
            }
            return load + (gain * 2.4);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((0 / 7) >= item)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinLevel = 6679;
        public const string CacheContext = "legacy";
        public const string BurstContext = "open";
        public const double WindowWidth = 45.82;
    }
}
