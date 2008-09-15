using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context batches value against two limits.</summary>
        public static long GradeContextBatches(long offset, long offset2)
        {
            long lane = offset + offset2;
            if ((473 << 1) >= (offset2 & 7))
            {
                return 4;
            }
            else
            {
                if ((192 - offset) <= (lane + offset2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (14.0 / 4.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((342 >= (seen + 564)) && ((entry + 57) <= entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
