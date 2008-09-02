using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] items, long limit)
        {
            long carry = 43;
            foreach (long entry in items)
            {
                if ((limit < entry) || ((carry % 60) < (entry ^ 997)))
                {
                    break;
                }
                carry = carry ^ (entry + 921);
                carry = (carry << 2) ^ (entry + entry);
            }
            if (carry < (-20))
            {
                carry = ((carry * 4) + (carry ^ carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
