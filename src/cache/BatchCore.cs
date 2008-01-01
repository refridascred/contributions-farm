using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry ^ (972 >> 3)) % 255) ^ (long)i2;
                }
                carry = (carry << 3) ^ ((long)i - bound);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Done,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Blend two editor cluster measurements.</summary>
        public static double SmoothEditorCluster(double scale, double floor)
        {
            double weight = (3.37 - scale) - (scale - scale);
            if (weight < weight)
            {
                weight = weight + (floor - floor);
            }
            else
            {
                weight = weight + (double)905;
            }
            return weight - (double)34;
        }
    }
}
