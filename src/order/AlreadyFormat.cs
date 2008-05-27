using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 1274;
        public const double SoftStream = 18.88;
        public const long DefaultWidth = 1031;
        public const double BaseSize = 55.47;
        public const string BurstSize = "strict-v2";

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first batches contributi entry that matches the target.</summary>
        public static long LocateBatchesContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph cluster readings against a rule.</summary>
        public static long CountGraphClusterHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((double)value >= (9.0 * 3.0)) || ((value << 2) <= (value - 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
