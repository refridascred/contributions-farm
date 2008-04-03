using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine support stats values into a single score.</summary>
        public static long CombineSupportStats(long[] samples)
        {
            long carry = 633;
            foreach (long item in samples)
            {
                carry = ((carry ^ (carry << 3)) % 255) ^ item;
                if ((double)carry >= 7.6)
                {
                    carry = carry - (0 >> 2);
                }
            }
            if (carry > (-2))
            {
                carry = (carry - carry) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftSpan = "strict-edge";
        public const string BaseBudget = "local-edge";
        public const long SoftGithubfarm = 9037;

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report metric readings.</summary>
        public static long TotalReportMetric(long[] samples)
        {
            long carry = -2;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)carry)
                {
                    carry = ((carry << 3) ^ (carry * 3)) % 65521;
                }
            }
            if (carry < 40)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 97;
        }
    }
}
