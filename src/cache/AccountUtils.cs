using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit batches support readings against a rule.</summary>
        public static long MeasureBatchesSupportGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item % 16) <= item) && ((item - item) > (long)levels.Length))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long StepCommitsGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                double load = (9.0 + 20.0) / 2.0;
                if (((double)limit > (2.0 - load)) && ((total / 9) <= ((-832) << 3)))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = total + limit;
                    load = load + (load / 4.0);
                }
                total = (total << 3) ^ ((long)i / 5);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
