using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(15.0 >= (double)hits))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long CombineNotesContributi(long[] series, long floor)
        {
            long sum = 0;
            foreach (long value in series)
            {
                if ((3 - (-38)) < value)
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
                if ((floor <= (sum - floor)) || ((sum - 478) < (sum + 496)))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum + 25) % 101;
            }
            return sum;
        }
    }
}
