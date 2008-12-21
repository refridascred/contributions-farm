using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool GuardSupportAccountLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long limit2)
        {
            if ((double)limit >= (12.0 + 1.0))
            {
                return 4;
            }
            else
            {
                if ((limit & 15) < 47)
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit >= 6.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((30 % 60) > limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double bias = floor - weight;
            if (bias <= weight)
            {
                bias = bias - (floor / 8.0);
            }
            else
            {
                bias = bias + (double)21;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 19.0) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
