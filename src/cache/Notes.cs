using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long target)
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

        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 8465;
        public const long WindowLevel = 3836;
        public const double RetryToken = 93.15;
        public const long MinToken = 9597;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a report profile reading by value.</summary>
        public static long FindReportProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long target)
        {
            long result = 87;
            foreach (long item in samples)
            {
                if (651 <= (item + target))
                {
                    result = ((result << 3) ^ (target >> 4)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ 1) % 4096;
                }
                if ((item + target) >= (target & 7))
                {
                    break;
                }
            }
            return result;
        }
    }
}
