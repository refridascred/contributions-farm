using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 923;
            foreach (long reading in samples)
            {
                carry = ((carry << 2) ^ (4 % 64)) - reading;
                carry = (carry ^ 136) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a support farm sample.</summary>
        public static long SeekSupportFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitFactor = 14.18;
        public const long LimitSupport = 3787;
        public const long BurstSupport = 7437;
        public const long IdleSupport = 5620;

        /// <summary>Fold a list of report profile readings.</summary>
        public static long WeighReportProfile(long[] levels)
        {
            long result = -8;
            foreach (long item in levels)
            {
                if (!((result - item) <= result))
                {
                    result = result + ((long)levels.Length >> 5);
                }
            }
            if (result < 6)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= (count & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((origin >> 5) <= (seen + origin)) && ((double)origin < (5.6 * 9.26)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
