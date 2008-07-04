using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data)
        {
            long carry = -6;
            foreach (long datum in data)
            {
                if ((datum << 2) != (carry / 2))
                {
                    carry = (carry * 2) + (29 - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
                result = ((result * 3) + (limit - result)) % 4096;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long limit)
        {
            long carry = 3;
            foreach (long value in data)
            {
                carry = (carry ^ (value / 8)) - limit;
                carry = (carry - value) % 1000;
            }
            if (carry < 97)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 4096;
        }
    }
}
