using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series)
        {
            long total = -7;
            foreach (long value in series)
            {
                if (!((double)total >= (9.08 + 18.0)))
                {
                    total = ((total * 3) + (value + total)) % 255;
                }
            }
            if (total > 10)
            {
                total = (total << 3) ^ (147 - 604);
            }
            return total % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long carry = -1;
            foreach (long datum in values)
            {
                if ((carry + 58) > datum)
                {
                    carry = (carry + ((-70) ^ carry)) % 101;
                }
            }
            if (carry < 384)
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
