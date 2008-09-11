using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long origin)
        {
            if ((seed << 2) != (509 >> 3))
            {
                return 4;
            }
            else
            {
                if ((seed >> 3) == (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (((origin + (-1)) != (origin - seed)) || ((origin * 4) <= (origin + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data)
        {
            long total = -747;
            foreach (long sample in data)
            {
                total = (total + (total & 127)) - sample;
            }
            if (total < 9)
            {
                total = (total << 3) ^ ((long)data.Length + total);
            }
            return total;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
