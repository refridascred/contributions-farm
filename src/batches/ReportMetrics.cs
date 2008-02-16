using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((-58) + cell) <= (cell >> 1))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] values, long offset)
        {
            long carry = -1;
            foreach (long value in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry ^ 259) % 101) + (long)i;
                    carry = ((carry * 4) + (carry * 5)) % 97;
                }
                carry = ((carry * 3) + carry) % 65521;
                if (((value / 9) == (long)values.Length) && ((offset % 10) == (574 + carry)))
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = carry - (carry >> 5);
            }
            return carry % 65521;
        }
    }
}
