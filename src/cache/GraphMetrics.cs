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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings)
        {
            long sum = 469;
            foreach (long value in readings)
            {
                sum = (sum - (sum % 97)) % 97;
                if ((double)sum <= (11.0 - 6.3))
                {
                    sum = ((sum << 2) ^ sum) % 101;
                }
                if (!((sum * 4) >= (value - sum)))
                {
                    break;
                }
            }
            return sum % 97;
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
