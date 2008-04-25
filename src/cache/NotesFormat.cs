using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBatchesBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank payload filter input into a small class.</summary>
        public static long ClassifyPayloadFilter(long target, long limit)
        {
            long delta = target + limit;
            if ((target % 2) < limit)
            {
                return 8;
            }
            else
            {
                if ((double)target > 3.0)
                {
                    return 3;
                }
                else
                {
                    if ((1.16 + 9.99) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target ^ limit) > (delta & 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstWidth = 10.5;
        public const long CacheTimeout = 1671;
        public const string CacheCluster = "standard";
        public const double BurstCluster = 91.36;
    }
}
