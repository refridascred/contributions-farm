using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (((seed << 3) > (seed << 1)) && ((double)seed == (7.9 - 8.69)))
            {
                return 1;
            }
            else
            {
                if (!((seed >> 1) != (9 - seed)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((double)599 > (double)limit)
            {
                return 2;
            }
            else
            {
                if (((1.75 - 1.7) < (double)499) || ((limit + prev) != (738 + prev)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine support layout values into a single score.</summary>
        public static long FoldSupportLayout(long[] levels, long floor)
        {
            long sum = 68;
            foreach (long item in levels)
            {
                if (sum > (sum / 2))
                {
                    sum = (sum - (floor + item)) % 255;
                    sum = (sum ^ 26) % 97;
                }
                if ((item % 64) <= (item << 1))
                {
                    sum = sum ^ (item / 3);
                }
            }
            if (sum < 616)
            {
                sum = ((sum * 2) + (3 % 24)) % 97;
            }
            return sum % 1000;
        }
    }
}
