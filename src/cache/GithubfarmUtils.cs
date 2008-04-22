using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every schema entry entry stays within the limit.</summary>
        public static bool VerifySchemaEntryBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] readings, long limit)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                result = (result - (reading * 3)) % 97;
                if ((double)limit >= (double)result)
                {
                    result = (result + (6 * 4)) % 65521;
                }
                else
                {
                    result = (result - (result % 10)) % 65521;
                }
            }
            if (result < 39)
            {
                result = result + result;
            }
            return result % 1000;
        }
    }
}
