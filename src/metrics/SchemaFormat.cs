using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings)
        {
            long score = 947;
            foreach (long item in readings)
            {
                if ((3.8 / 2.0) > (double)item)
                {
                    score = (score - (score + score)) % 4096;
                }
                if (((item * 2) != (item & 63)) && ((item >> 5) > (score + score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Label { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if ((7.05 - 6.9) == (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)limit < 6.2)
                {
                    return 6;
                }
                else
                {
                    if (!(limit >= (origin % 100)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((2 >> 5) > (limit & 31)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
