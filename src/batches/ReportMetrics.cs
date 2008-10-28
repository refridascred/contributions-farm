using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items, long origin)
        {
            long mix = 529;
            foreach (long value in items)
            {
                mix = (mix + (long)items.Length) % 4096;
                if ((double)value == (double)(long)items.Length)
                {
                    mix = ((mix * 5) + (mix + 571)) % 97;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (origin - origin)) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)step >= 3.9))
                {
                    break;
                }
                else
                {
                    carry = carry + (carry - 372);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
