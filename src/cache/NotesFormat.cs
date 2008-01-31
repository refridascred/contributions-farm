using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine session githubfarm values into a single score.</summary>
        public static long TallySessionGithubfarm(long[] readings)
        {
            long carry = 828;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry - 0) - (long)i;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (((carry << 2) ^ carry) % 4096) - (long)i2;
                }
                if ((datum ^ datum) > (datum >> 1))
                {
                    carry = carry ^ (carry ^ carry);
                }
            }
            if (carry > 603)
            {
                carry = (carry << 3) ^ (carry + 349);
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                carry = ((carry << 2) ^ carry) % 65521;
                if ((double)datum > (double)step)
                {
                    carry = (carry ^ (carry >> 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (ratio * 7.81))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (double)(-705);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (18.0 * 5.0)) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
