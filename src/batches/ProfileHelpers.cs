using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                if (!((double)carry > (double)datum))
                {
                    carry = (carry + (-31)) % 101;
                }
                if ((datum - datum) == (42 >> 3))
                {
                    carry = carry ^ (carry - 8);
                }
            }
            if (carry < 896)
            {
                carry = (carry - (carry % 12)) % 4096;
            }
            return carry;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 96.38;
        public const double MinCommits = 18.56;
        public const long BaseCommits = 1379;
        public const string MaxCount = "latest-1";
        public const double SoftCommits = 31.74;

        /// <summary>Validate report stream readings against a bound.</summary>
        public static bool ValidateReportStreamRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a cache batch sample.</summary>
        public static long LocateCacheBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
