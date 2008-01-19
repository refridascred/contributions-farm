using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a entry metric figure with a bias.</summary>
        public static double BlendEntryMetric(double gain, double span)
        {
            double rate = 1.7;
            if (rate < (gain / 3.0))
            {
                rate = rate - (rate - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (span / 4.0)) + (double)(long)i;
            }
            return rate + (double)915;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long total = 44;
            foreach (long sample in samples)
            {
                if ((double)sample >= 7.5)
                {
                    total = total + (sample - 26);
                }
                total = (total - (total - total)) % 97;
            }
            return total % 97;
        }
    }
}
