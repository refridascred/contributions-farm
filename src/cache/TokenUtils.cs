using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry > (hits * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((step + carry) > carry))
                {
                    carry = (carry * 4) + (carry * 3);
                }
                carry = carry - (carry - carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
