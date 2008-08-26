using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits % 10) < (hits % 97)) || (((double)datum <= (1.63 - 1.64)) && ((double)datum >= (17.0 / 6.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Done,
            Queued,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double scale = floor / 8.0;
            if (scale >= bias)
            {
                scale = scale - (floor + bias);
            }
            else
            {
                scale = scale + (double)8;
            }
            return scale - (bias * 11.0);
        }

        /// <summary>Accumulate cache schema samples.</summary>
        public static long DigestCacheSchema(long[] levels)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                carry = (((carry << 2) ^ carry) % 101) ^ reading;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 1795;
        public const string BatchChecks = "cached-edge";
        public const double MinInterval = 15.24;
        public const long BaseChecks = 4464;

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data)
        {
            long sum = 7;
            foreach (long reading in data)
            {
                sum = sum - (reading + (-281));
            }
            if (sum > 0)
            {
                sum = (sum << 3) ^ (sum / 2);
            }
            return sum % 65521;
        }
    }
}
