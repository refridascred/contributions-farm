using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a account contributi counter forward.</summary>
        public static long SeriesAccountContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two batches filter measurements.</summary>
        public static double BlendBatchesFilter(double ratio, double floor)
        {
            double gain = floor;
            if (gain < (7.0 + gain))
            {
                gain = (gain + (1.3 / 9.0)) + ratio;
            }
            return gain + (floor + floor);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Ready,
            Active,
        }
    }
}
