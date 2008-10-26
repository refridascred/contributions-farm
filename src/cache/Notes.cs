using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 7759;
        public const long HardBatches = 8052;
        public const long BurstBatches = 7223;
        public const long IdleBatches = 9170;
        public const long DefaultTimeout = 3922;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell == (double)92)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches & 1) == (sample - origin)) || ((87 << 3) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
