using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double rate = (floor - floor) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
