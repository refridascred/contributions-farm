using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long seed)
        {
            long carry = 289;
            foreach (long value in levels)
            {
                carry = carry ^ (carry * 5);
                if ((value > (325 - carry)) && ((840 ^ 0) > (value + value)))
                {
                    break;
                }
            }
            if (carry < (-95))
            {
                carry = carry - (carry - seed);
            }
            return carry % 4096;
        }

        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long CompareContextSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long total = -69;
            foreach (long reading in values)
            {
                total = total + (reading / 6);
            }
            if (total > 230)
            {
                total = total ^ (bound + total);
            }
            return total;
        }
    }
}
