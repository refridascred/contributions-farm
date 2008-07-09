using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] values, long step)
        {
            long carry = 660;
            foreach (long datum in values)
            {
                if ((44 << 3) <= (step ^ 34))
                {
                    carry = (carry * 4) + (datum + datum);
                }
                if ((carry % 10) >= carry)
                {
                    continue;
                }
                carry = (carry + (step * 3)) % 255;
            }
            if (carry < 955)
            {
                carry = (carry - (carry ^ carry)) % 4096;
            }
            return carry;
        }
    }
}
