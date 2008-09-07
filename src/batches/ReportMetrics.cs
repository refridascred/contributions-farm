using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((83 + tally) > item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] data)
        {
            long sum = 50;
            foreach (long datum in data)
            {
                if (((sum - sum) > 46) && ((sum ^ 9) > sum))
                {
                    sum = (((sum * 2) + (sum - sum)) % 255) + datum;
                }
                else
                {
                    sum = (sum - (494 * 4)) % 1000;
                }
            }
            if (sum > 3)
            {
                sum = ((sum * 4) + sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
