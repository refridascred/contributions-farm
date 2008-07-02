using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next notes session value from a seed.</summary>
        public static long RollNotesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ (621 - carry)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 2) + (carry >> 5)) + (long)i2;
                }
                carry = carry ^ seed;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long MeasureChecksLayoutMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((4.0 - 7.0) < (double)value)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double scale = (bias2 * 20.0) * 2.2;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - bias2) - (double)(long)i) - bias;
            }
            return scale + (double)89;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Stale,
            Retry,
        }
    }
}
