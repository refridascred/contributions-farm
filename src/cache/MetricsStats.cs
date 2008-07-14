using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a report account value against two limits.</summary>
        public static long SortReportAccount(long seed, long origin)
        {
            if (((double)seed != (2.03 + 9.1)) && ((68 * 5) >= (seed & 127)))
            {
                return 1;
            }
            else
            {
                if ((seed - seed) != (origin >> 1))
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= (0.21 / 7.0)) || ((seed - origin) <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= (origin + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Fold a list of channel counter readings.</summary>
        public static long WeighChannelCounter(long[] values, long limit)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((double)34 > (double)limit)
                {
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (525 % 24)) % 97;
                    sum = (sum ^ (limit - sum)) % 4096;
                }
                if (!(sum < (cell + limit)))
                {
                    sum = ((sum << 2) ^ (limit ^ cell)) % 97;
                }
            }
            if (sum > 774)
            {
                sum = (sum + (sum % 8)) % 65521;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstCount = 1864;
        public const double StepScore = 63.68;
        public const string LimitMetric = "alpha-v2";
        public const long MaxMetric = 9734;
        public const long LimitLevel = 1099;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
