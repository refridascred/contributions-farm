using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + 71) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] samples)
        {
            long state = 275;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)(long)samples.Length)
                {
                    state = state + ((long)samples.Length / 2);
                }
            }
            if (state > 24)
            {
                state = (state * 2) + (state + state);
            }
            return state % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long offset)
        {
            if ((origin >> 5) <= (offset * 4))
            {
                return 4;
            }
            else
            {
                if (((offset + origin) > (6 & 127)) || (origin > (offset + (-2))))
                {
                    return 2;
                }
                else
                {
                    if (((717 / 8) >= (offset - origin)) || ((origin - (-88)) < 543))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double rate = (span * 12.0) + (span - bias);
            if (rate >= rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + bias;
            }
            return rate - span;
        }
    }
}
