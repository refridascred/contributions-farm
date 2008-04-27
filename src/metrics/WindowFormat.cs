using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            New,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1517;
        public const long BaseTimeout = 9214;
        public const string LimitWidth = "stable-1";
        public const string BurstPayload = "standard-1";

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-59) ^ (-385)) > sample)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                if ((0.7 + 5.07) >= (double)offset)
                {
                    result = (result + (item & 63)) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result - (offset * 2)) % 1000;
            }
            return result;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double load = 9.0;
            if (load > offset)
            {
                load = (load + (offset + offset)) + rate;
            }
            return load + (load * 13.0);
        }
    }
}
