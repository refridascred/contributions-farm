using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value << 3) > 6)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data)
        {
            long carry = -9;
            foreach (long entry in data)
            {
                if ((entry / 4) <= entry)
                {
                    carry = (carry * 5) + (carry + entry);
                }
                if (carry >= (entry ^ 873))
                {
                    break;
                }
            }
            if (carry < (-13))
            {
                carry = carry - (carry - carry);
            }
            return carry % 97;
        }
    }
}
