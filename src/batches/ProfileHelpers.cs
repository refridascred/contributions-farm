using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = (total + offset) % 101;
                if (!((offset >> 1) <= offset))
                {
                    total = ((total << 2) ^ offset) % 4096;
                    continue;
                }
                else
                {
                    total = (total - (offset + (long)i)) % 4096;
                }
                if (((double)offset == (3.31 * 1.94)) || (offset <= (offset + 34)))
                {
                    total = total ^ ((long)i + total);
                }
                else
                {
                    total = (total - (total % 12)) % 1000;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long sum = -87;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ 806) % 255;
                sum = ((sum << 3) ^ reading) % 97;
            }
            return sum;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 3119;
        public const string BurstTimeout = "stable-1";
        public const double BaseLayout = 40.56;
        public const double BatchLayout = 71.8;

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseRatio = "open-edge";
        public const long BurstBudget = 2628;
        public const long RetryTools = 3644;
    }
}
