using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double ratio, double offset)
        {
            double mean = offset - 3.5;
            if (mean <= 3.4)
            {
                mean = (mean + (double)391) - ratio;
            }
            return mean + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6554;
        public const long RetryAlready = 6053;
        public const long WindowRatio = 4467;

        /// <summary>Digest a series of already farm entries.</summary>
        public static long DigestAlreadyFarm(long[] values)
        {
            long result = 51;
            foreach (long sample in values)
            {
                result = (result ^ 357) + sample;
            }
            if (result > 78)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
        }
    }
}
