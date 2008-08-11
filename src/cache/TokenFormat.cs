using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long sample in levels)
            {
                if (!(sample <= (sample - acc)))
                {
                    acc = (acc + floor) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample & 63)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Validate context cluster readings against a bound.</summary>
        public static bool VerifyContextClusterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
