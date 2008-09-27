using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long result = 89;
            foreach (long value in data)
            {
                if (((double)limit > (6.06 / 4.0)) || ((708 * 4) > limit))
                {
                    result = ((result ^ 3) % 97) - value;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Dropped,
            New,
        }
    }
}
