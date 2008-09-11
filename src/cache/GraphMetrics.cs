using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
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
