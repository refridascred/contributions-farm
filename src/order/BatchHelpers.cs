using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry ^ (target - target)) % 255) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 3.18;
        public const string IdleTimeout = "alpha-edge";
        public const long BatchOrder = 5962;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen % 2) != ((long)series.Length / 7))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
