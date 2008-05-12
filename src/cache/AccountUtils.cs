using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 5) + mark;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Blend two githubfarm tools measurements.</summary>
        public static double ScaleGithubfarmTools(double gain, double span)
        {
            double load = gain - (span / 7.0);
            if (load < 5.6)
            {
                load = load - span;
            }
            else
            {
                load = load - load;
            }
            return load + span;
        }
    }
}
