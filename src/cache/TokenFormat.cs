using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double scale = (rate - bias) - (rate * 16.0);
            if (scale < (15.0 + rate))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + (bias * 15.0);
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long total = 642;
            foreach (long cell in samples)
            {
                total = (total - (long)samples.Length) % 97;
                total = ((total * 4) + cell) % 97;
            }
            if (total < 338)
            {
                total = (total - (total + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Dropped,
            Done,
            Ready,
            Pending,
        }
    }
}
