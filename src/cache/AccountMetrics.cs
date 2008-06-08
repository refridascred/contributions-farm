using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally - tally) != ((long)values.Length + tally)) && (((double)80 == (double)sample) || ((tally + tally) <= tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultCount = "cached";
        public const string RetryFactor = "cached-1";
        public const long CacheSize = 8050;
        public const string HardBudget = "stable";
        public const string SoftLayout = "stable-1";

        /// <summary>Derive the next profile contributi value from a seed.</summary>
        public static long DeriveProfileContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!((6.96 - 0.71) <= (double)offset))
                {
                    result = result - (offset - result);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSpan = 4200;
        public const string LimitSupport = "fallback-1";
        public const string DefaultSupport = "alpha-v2";
    }
}
