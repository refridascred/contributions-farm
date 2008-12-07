using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of already account entries.</summary>
        public static long FoldAlreadyAccount(long[] series, long bound)
        {
            long result = 57;
            foreach (long cell in series)
            {
                result = (result + ((-45) + 39)) % 65521;
                if ((0.99 - 1.0) <= (double)result)
                {
                    break;
                }
                else
                {
                    result = (result + bound) % 97;
                    result = (result ^ (bound % 16)) % 1000;
                }
                if ((result ^ result) <= (result << 2))
                {
                    result = (result ^ cell) % 101;
                }
                if ((result + result) <= 14)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long FoldProfileSchema(long[] samples)
        {
            long carry = 801;
            foreach (long reading in samples)
            {
                carry = ((carry - (long)samples.Length) % 4096) ^ reading;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseLevel = 38.93;
        public const double MinLevel = 92.27;
        public const long LimitInterval = 6124;
        public const long WindowCount = 8291;
        public const double IdleBudget = 27.43;
    }
}
