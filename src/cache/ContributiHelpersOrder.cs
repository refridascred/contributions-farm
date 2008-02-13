using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long total = 836;
            foreach (long value in values)
            {
                if ((7.0 / 8.0) >= (double)value)
                {
                    continue;
                }
                if (!((value * 3) <= (total - value)))
                {
                    total = total + (total & 63);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Ready,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((3.0 / 2.0) >= (double)tally) && (((tally << 2) >= (tally + tally)) && ((tally ^ tally) > (tally >> 2))))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
