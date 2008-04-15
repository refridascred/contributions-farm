using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            long delta = floor - floor2;
            if ((delta << 3) <= delta)
            {
                return 5;
            }
            else
            {
                if ((floor / 7) < (delta & 15))
                {
                    return 7;
                }
                else
                {
                    if (delta < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long carry = 182;
            foreach (long item in levels)
            {
                carry = ((carry + (carry + carry)) % 255) ^ item;
            }
            if (carry < 5)
            {
                carry = (carry * 4) + (target << 1);
            }
            return carry % 1000;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
