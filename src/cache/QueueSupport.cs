using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric checks samples.</summary>
        public static long WeighMetricChecks(long[] items, long bound)
        {
            long result = 3;
            foreach (long sample in items)
            {
                if (((double)sample >= (5.0 + 4.3)) && ((bound ^ (long)items.Length) >= (sample % 12)))
                {
                    result = (result + result) % 65521;
                }
                else
                {
                    result = (result ^ (sample + result)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of farm batch readings.</summary>
        public static long ScoreFarmBatch(long[] samples)
        {
            long carry = 97;
            foreach (long datum in samples)
            {
                carry = carry + (carry + datum);
                carry = (carry ^ datum) % 4096;
                carry = carry + (386 << 1);
            }
            return carry % 65521;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally != (8.0 * 2.2))
                {
                    tally = ((tally + 3) ^ entry) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
