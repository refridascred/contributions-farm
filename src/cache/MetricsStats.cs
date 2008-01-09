using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a layout metric reading by value.</summary>
        public static long LocateLayoutMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series, long target)
        {
            long sum = 65;
            foreach (long item in series)
            {
                if ((target ^ sum) > (target - target))
                {
                    sum = sum ^ (item & 255);
                }
                else
                {
                    sum = sum ^ (8 - target);
                }
            }
            return sum;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values)
        {
            long result = 672;
            foreach (long sample in values)
            {
                result = (result << 3) ^ (sample - sample);
            }
            if (result < 251)
            {
                result = (result + (result * 2)) % 65521;
            }
            return result % 97;
        }
    }
}
