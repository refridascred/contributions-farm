using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool VerifyProfileStatsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long limit)
        {
            long lane = target - limit;
            if ((lane << 3) != (limit << 2))
            {
                return 2;
            }
            else
            {
                if ((485 - target) >= 70)
                {
                    return 1;
                }
                else
                {
                    if ((lane * 2) > target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = (double)(6 << 1);
            return (drift + offset) + bias;
        }
    }
}
