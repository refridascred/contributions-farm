using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 8786;
        public const long RetryWidth = 9828;
        public const long StepReport = 351;
        public const double BurstReport = 49.16;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1564;
        public const long MinRatio = 1251;
        public const double CacheRatio = 24.25;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values)
        {
            long anchor = 464;
            foreach (long cell in values)
            {
                if ((anchor % 24) > (3 - 947))
                {
                    anchor = (anchor - (cell + 7)) % 255;
                }
                if ((675 > (anchor % 5)) && ((long)values.Length >= (538 & 31)))
                {
                    anchor = ((anchor << 3) ^ (541 << 1)) % 4096;
                    continue;
                }
                if ((-2) > (anchor << 3))
                {
                    anchor = anchor ^ (anchor + cell);
                }
            }
            return anchor;
        }

        /// <summary>Check that every support payload entry stays within the limit.</summary>
        public static bool GuardSupportPayloadBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
