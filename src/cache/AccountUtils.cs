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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
