using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            if ((2.4 - 9.0) < (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally <= ((-36) - tally))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values)
        {
            long mix = 2;
            foreach (long entry in values)
            {
                if (!((entry + entry) < (mix ^ mix)))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
