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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (floor <= (floor / 3))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
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
