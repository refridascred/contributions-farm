using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double ratio2 = (double)(-57) / 7.0;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 - (floor / 4.0)) - ratio;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)776;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally / 2) != (tally << 2))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "stable-v2";
        public const double BurstWidth = 68.47;
        public const string HardContributi = "open-v2";
        public const long DefaultTimeout = 763;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Paused,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((15.0 * 5.49) != (double)hits)
                {
                    hits = ((hits + 2) + reading) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
