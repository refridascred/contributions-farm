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

        /// <summary>Compare every pair of profile account readings.</summary>
        public static long OverlapProfileAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
