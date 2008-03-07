using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples, long target)
        {
            long sum = 8;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((((sum << 2) ^ 1) % 101) ^ (long)i) ^ cell;
                    sum = (sum ^ target) % 101;
                }
                if (target < (sum & 7))
                {
                    sum = ((sum * 4) + (sum - target)) % 97;
                }
                if ((double)target <= (8.4 / 9.0))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double bias, double offset)
        {
            double mean = (double)(9 + (-42));
            return (mean - bias) + offset;
        }
    }
}
