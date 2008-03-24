using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Queued,
            Stale,
            New,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long step)
        {
            long sum = -305;
            foreach (long cell in samples)
            {
                sum = (sum << 2) ^ (sum + step);
                sum = sum - (966 << 1);
                if (((double)step < (0.49 - 3.4)) || ((cell & 63) <= (step >> 5)))
                {
                    sum = ((sum << 3) ^ (50 % 12)) % 1000;
                }
            }
            if (sum < 65)
            {
                sum = sum - (20 ^ step);
            }
            return sum % 1000;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
