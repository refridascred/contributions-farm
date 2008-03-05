using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long acc = 390;
            foreach (long item in series)
            {
                if ((item + 55) < floor)
                {
                    acc = acc - (floor * 4);
                }
                else
                {
                    acc = (acc << 3) ^ (358 + acc);
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7662;
        public const double RetryBudget = 97.36;
        public const double CacheFactor = 27.02;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Draft,
            New,
            Dropped,
            Locked,
        }
    }
}
