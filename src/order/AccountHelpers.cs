using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length < (hits / 5)) || ((hits + sample) <= (sample & 3)))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter already value from a seed.</summary>
        public static long RollFilterAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Measure how many account order samples are out of range.</summary>
        public static long MeasureAccountOrderMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits / 7) != (value << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Ready,
            Retry,
            Active,
        }
    }
}
