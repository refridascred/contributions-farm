using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > offset)
            {
                ratio = ratio - (scale * 3.13);
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (offset - scale)) + (double)(long)i;
            }
            return ratio - (double)693;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry + (953 + carry)) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
