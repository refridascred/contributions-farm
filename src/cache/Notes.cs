using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine context stats values into a single score.</summary>
        public static long WeighContextStats(long[] readings)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                if ((sample - result) == (result % 64))
                {
                    result = (result ^ (996 >> 1)) % 97;
                }
                else
                {
                    result = (result * 5) + result;
                }
            }
            return result;
        }

        /// <summary>Find the first tools metrics entry that matches the target.</summary>
        public static long SeekToolsMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Rank queue filter input into a small class.</summary>
        public static long BucketQueueFilter(long origin, long floor)
        {
            long cur = origin - floor;
            if ((floor + floor) <= (cur % 3))
            {
                return 1;
            }
            else
            {
                if (((floor + origin) > (origin >> 1)) || ((double)610 == (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (!((floor << 3) > (floor + 18)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin > (862 + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
