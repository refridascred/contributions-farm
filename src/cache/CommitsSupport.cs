using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the commits stream entries that pass the check.</summary>
        public static long AuditCommitsStreamOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count >= (18.0 + 9.9))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 1922;
        public const long CacheScore = 309;
        public const long DefaultDepth = 8161;

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first notes schema entry that matches the target.</summary>
        public static long SeekNotesSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 9140;
        public const double DefaultFactor = 31.8;
        public const double RetryInterval = 8.15;

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool ValidateBufferContributiBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
