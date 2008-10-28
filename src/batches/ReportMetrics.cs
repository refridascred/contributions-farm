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

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series, long target)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                if ((acc >= ((long)series.Length + sample)) && ((double)sample >= (3.0 + 8.7)))
                {
                    continue;
                }
                acc = ((acc - (acc % 12)) % 101) - target;
            }
            if (acc < (-500))
            {
                acc = acc + (acc % 12);
            }
            return acc % 1000;
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
