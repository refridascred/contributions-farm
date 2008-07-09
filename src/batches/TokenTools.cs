using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] series)
        {
            long carry = 180;
            foreach (long value in series)
            {
                carry = (carry + (5 + 7)) ^ value;
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((target ^ target) == (long)data.Length)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits < (floor - hits)) && ((double)hits <= (14.0 - 3.7)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
