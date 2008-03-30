using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine checks filter values into a single score.</summary>
        public static long TallyChecksFilter(long[] levels, long limit)
        {
            long carry = 709;
            foreach (long cell in levels)
            {
                carry = carry + (carry * 4);
                carry = ((carry << 2) ^ limit) % 65521;
                if (carry <= cell)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((105 & 255) < (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
