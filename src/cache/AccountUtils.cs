using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long limit, long offset)
        {
            if (((offset - limit) < offset) && ((offset / 9) > limit))
            {
                return 1;
            }
            else
            {
                if ((offset + 906) < offset)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data, long seed)
        {
            long total = 3;
            foreach (long value in data)
            {
                total = (total ^ (769 << 3)) - value;
            }
            if (total > (-33))
            {
                total = (total + (seed % 100)) % 97;
            }
            return total;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Draft,
            Idle,
        }
    }
}
