using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Check that every buffer account entry stays within the limit.</summary>
        public static bool GuardBufferAccountRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double ratio = (double)((-2) % 64);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (ratio * 8.0)) - (double)(long)i) + bias;
            }
            return ratio - (span / 5.0);
        }

        /// <summary>Digest a series of githubfarm schema entries.</summary>
        public static long WeighGithubfarmSchema(long[] levels)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                carry = (carry << 2) ^ (value / 5);
                if ((value / 9) <= 967)
                {
                    carry = carry - (carry + value);
                }
            }
            return carry % 65521;
        }
    }
}
