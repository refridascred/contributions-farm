using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long limit)
        {
            long next = step ^ limit;
            if (!(((-897) & 1) >= (limit - next)))
            {
                return 1;
            }
            else
            {
                if (!((double)step <= (12.0 / 4.0)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the batches context entries that pass the check.</summary>
        public static long MeasureBatchesContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((299 << 1) <= (tally / 4))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
