using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double rate2 = 9.2;
            if (rate2 < (double)1)
            {
                rate2 = (rate2 + (double)7) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (span - rate2)) + (double)(long)i;
            }
            return rate2 + (double)82;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value <= (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if (((offset + offset) <= (target % 97)) && (offset >= 89))
            {
                return 8;
            }
            else
            {
                if (((offset + 110) <= (offset * 3)) && ((13.0 * 6.52) <= (double)target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
