using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((11.0 / 6.0) > (double)seen)
                {
                    seen = ((seen + 3) - entry) - bound;
                }
            }
            return seen;
        }

        /// <summary>Find the first report stream entry that matches the target.</summary>
        public static long LookupReportStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = -334;
            foreach (long datum in items)
            {
                if ((datum - datum) < carry)
                {
                    carry = carry ^ 247;
                }
                if ((double)datum != (8.2 - 15.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a githubfarm queue sample.</summary>
        public static long LocateGithubfarmQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Retry,
            Active,
            Ready,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
