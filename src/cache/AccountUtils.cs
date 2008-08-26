using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long LookupChecksStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long step)
        {
            long step2 = limit ^ step;
            if ((step * 5) > step2)
            {
                return 3;
            }
            else
            {
                if ((limit - 48) > (step + step2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
