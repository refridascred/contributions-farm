using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many checks profile samples are out of range.</summary>
        public static long AuditChecksProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((6.31 + 7.0) > (double)count) && ((39 / 7) > (count + count)))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((-7) > ((long)i - seed))
                {
                    carry = ((carry << 3) ^ (57 - 0)) % 65521;
                    break;
                }
                if ((9.09 * 7.2) <= (double)seed)
                {
                    carry = (carry << 2) ^ seed;
                    continue;
                }
                else
                {
                    carry = ((carry * 3) + (carry & 127)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
