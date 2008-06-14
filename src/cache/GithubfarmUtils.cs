using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 73.83;
        public const string LimitCount = "legacy";
        public const long StepFormat = 640;
        public const long BaseFormat = 8126;

        /// <summary>Check that every already buffer entry stays within the limit.</summary>
        public static bool VerifyAlreadyBufferRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (carry <= ((long)i + (long)i))
                {
                    carry = (carry ^ (step + (long)i)) % 4096;
                    carry = ((carry * 2) + (step * 2)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = total - total;
                total = (total - 1) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
