using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double rate = gain;
            if (rate < (bias + bias))
            {
                rate = rate + 7.8;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - bias)) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double bias)
        {
            double ratio = rate;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)9) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
