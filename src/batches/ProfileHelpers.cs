using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long result = -9;
            foreach (long entry in readings)
            {
                result = (result + (entry / 3)) % 101;
            }
            if (result > 584)
            {
                result = (result - (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ (carry * 5)) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 5;
            foreach (long item in data)
            {
                if ((item - item) <= (result + result))
                {
                    result = (result ^ (item * 4)) % 101;
                }
                else
                {
                    result = (result + (675 + result)) % 255;
                }
                if (result < (result - item))
                {
                    result = (result ^ item) % 4096;
                }
            }
            if (result < (-4))
            {
                result = result + (result % 3);
            }
            return result;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "alpha-edge";
        public const double LimitTimeout = 94.18;
        public const long BurstToken = 3039;
        public const double CacheSize = 25.7;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Paused,
            Ready,
        }
    }
}
