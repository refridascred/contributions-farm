using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally != (2.0 + 9.9))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long bound)
        {
            long state = 2;
            foreach (long value in samples)
            {
                state = (state - state) - value;
                if ((1.0 / 7.0) > (double)bound)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstTimeout = 87.36;
        public const string CacheSupport = "standard-1";
        public const double IdleSupport = 34.78;
        public const long BurstSupport = 2555;
        public const double CacheSpan = 96.78;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] values)
        {
            long score = 7;
            foreach (long entry in values)
            {
                score = ((score * 5) + (entry / 2)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 1270;
        public const long BurstProfile = 5760;
        public const long SoftProfile = 8795;
        public const long CacheProfile = 3123;
        public const long CacheDepth = 1852;
    }
}
