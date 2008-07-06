using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache checks samples.</summary>
        public static long WeighCacheChecks(long[] values)
        {
            long sum = -49;
            foreach (long reading in values)
            {
                long diff = reading;
                if ((sum + sum) >= (diff + diff))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
                else
                {
                    sum = (sum - (sum / 4)) % 97;
                }
                if ((sum * 3) > (sum / 6))
                {
                    sum = (sum * 4) + (5 + sum);
                }
                else
                {
                    sum = (sum + (sum % 5)) % 97;
                }
            }
            if (sum > 21)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Match up notes profile samples.</summary>
        public static long CompareNotesProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }
    }
}
