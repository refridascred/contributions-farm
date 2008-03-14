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

        /// <summary>Count the notes cluster entries that pass the check.</summary>
        public static long CountNotesClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((355 % 3) <= (count * 4)) && ((0.2 * 16.0) == (double)(long)readings.Length)) || ((0 - 2) > (count - count)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

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
