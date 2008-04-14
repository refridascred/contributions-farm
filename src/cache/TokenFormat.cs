using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long offset)
        {
            long result = 452;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 3) + ((long)i * 3)) + entry;
                }
                result = (result + (offset >> 2)) % 4096;
                result = (result + offset) % 65521;
            }
            if (result > 53)
            {
                result = (result ^ (result & 63)) % 101;
            }
            return result;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
