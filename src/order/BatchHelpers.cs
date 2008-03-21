using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit layout farm readings against a rule.</summary>
        public static long TallyLayoutFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(((38 ^ seen) > (99 - seen)) && ((reading - 22) >= (seen % 12))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile editor entry stays within the limit.</summary>
        public static bool VerifyProfileEditorRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((7.56 * 3.0) > (double)cell) || ((cell + cell) >= (floor % 24)))
                {
                    tally = tally + 1;
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
