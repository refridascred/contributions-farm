using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((-57) + origin) < 658)
                {
                    sum = (sum + (113 + origin)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
