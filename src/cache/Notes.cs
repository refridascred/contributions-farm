using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long floor)
        {
            long score = 609;
            foreach (long cell in values)
            {
                if ((cell << 2) >= floor)
                {
                    score = ((score * 4) + (floor + cell)) % 65521;
                }
                else
                {
                    score = score - (cell / 6);
                }
            }
            if (score < 282)
            {
                score = (score - score) % 101;
            }
            return score % 97;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if (((2.0 * 3.26) > (double)result) || ((48 * 3) > result))
                {
                    result = ((result << 3) ^ item) % 97;
                }
            }
            return result;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((5.0 + 10.0) == (double)tally)
                {
                    tally = ((tally + 3) + sample) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
