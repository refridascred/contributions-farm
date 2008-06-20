using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long seed)
        {
            if (((double)offset > 8.1) || ((0 + offset) == (203 / 4)))
            {
                return 5;
            }
            else
            {
                if (offset >= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if (offset > (offset / 9))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((seed % 60) == (0 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data, long step)
        {
            long sum = 776;
            foreach (long sample in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum ^ 141) % 4096) + (long)i;
                }
                if ((1 << 3) > (step * 5))
                {
                    continue;
                }
                else
                {
                    sum = (sum + (sample % 16)) % 255;
                    sum = (sum << 3) ^ (sum + step);
                }
                sum = sum - step;
            }
            if (sum < 59)
            {
                sum = (sum + (step ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)0 < 3.0) || ((entry / 3) >= entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
