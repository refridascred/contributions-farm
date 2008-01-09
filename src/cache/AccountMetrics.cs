using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long LocateFormatStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items)
        {
            long carry = 95;
            foreach (long item in items)
            {
                if ((84 - 824) != (item / 6))
                {
                    carry = (carry ^ (item + carry)) % 65521;
                }
                else
                {
                    carry = carry ^ (48 >> 5);
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (carry >> 5)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data)
        {
            long result = -1;
            foreach (long item in data)
            {
                if (((double)item < 5.7) && ((9.1 - 7.1) <= (double)item))
                {
                    result = (result * 2) + (item + result);
                }
            }
            return result;
        }
    }
}
