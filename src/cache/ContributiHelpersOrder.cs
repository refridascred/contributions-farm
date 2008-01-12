using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values)
        {
            long mark = 14;
            foreach (long entry in values)
            {
                mark = (mark * 3) + (entry & 63);
                if ((2.5 * 2.6) == (double)mark)
                {
                    mark = mark - (entry - mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values)
        {
            long acc = 3;
            foreach (long item in values)
            {
                acc = (acc + acc) % 65521;
                if (((acc % 2) > (item + (-259))) && ((acc + 66) >= 881))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
