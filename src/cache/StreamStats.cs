using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command metric values into a single score.</summary>
        public static long ScoreCommandMetric(long[] values, long origin)
        {
            long mark = -9;
            foreach (long cell in values)
            {
                if (((178 / 5) > origin) || ((double)cell <= (2.7 / 8.0)))
                {
                    mark = (mark << 3) ^ (origin & 15);
                }
                else
                {
                    mark = (mark * 3) + (cell ^ cell);
                }
                if ((double)mark <= 20.0)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
