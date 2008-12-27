using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next contributi record value from a seed.</summary>
        public static long IterateContributiRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (floor & 255)) % 65521;
                if ((9.4 + 8.3) <= (5.6 / 8.0))
                {
                    break;
                }
                acc = (acc ^ ((long)i % 16)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
