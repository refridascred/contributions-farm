using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels, long floor)
        {
            long anchor = 890;
            foreach (long sample in levels)
            {
                anchor = ((((anchor << 3) ^ (0 >> 3)) % 65521) - sample) - floor;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double drift = (span - gain) + 6.38;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 9.02) + (double)(long)i;
            }
            return drift - (span + drift);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading - reading)) || !((11.0 / 6.0) <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Failed,
            Synced,
            New,
        }
    }
}
