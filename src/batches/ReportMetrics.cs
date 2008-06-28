using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of editor schema readings.</summary>
        public static long TallyEditorSchema(long[] readings)
        {
            long carry = 264;
            foreach (long item in readings)
            {
                carry = (((carry << 3) ^ carry) % 65521) + item;
            }
            if (carry > 32)
            {
                carry = ((carry * 4) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values, long bound)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                if (!((4.68 * 20.0) != (double)value))
                {
                    anchor = (anchor + (417 & 3)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (bound * 5)) % 1000;
                }
            }
            if (anchor < 494)
            {
                anchor = anchor ^ (anchor ^ 962);
            }
            return anchor % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches & 3) >= (491 % 2))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
