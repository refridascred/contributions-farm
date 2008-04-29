using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double bias2 = span / 6.0;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 + (double)776) + (double)(long)i) + bias;
            }
            return bias2 + (double)(-599);
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + ((long)i / 4)) % 97;
                acc = (acc - (floor >> 2)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
