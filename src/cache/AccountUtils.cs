using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Classify a commits token pair into a bucket.</summary>
        public static long ClassifyCommitsToken(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((limit2 * 3) <= limit)
            {
                return 7;
            }
            else
            {
                if (((524 + span) >= (limit2 & 15)) || (limit > (span - limit)))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit2 > (7.7 * 7.45)) && (8.4 <= (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data)
        {
            long carry = 76;
            foreach (long reading in data)
            {
                if ((double)carry <= 3.4)
                {
                    carry = ((carry ^ carry) % 101) + reading;
                }
                if (((long)data.Length % 7) == (carry * 2))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
