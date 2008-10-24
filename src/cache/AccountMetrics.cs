using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 6369;
        public const long CacheWindow = 7834;
        public const double RetryScore = 8.52;

        /// <summary>Derive the next stats stream value from a seed.</summary>
        public static long StepStatsStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                long tally = limit + (sum + (long)i);
                if (tally >= (long)i)
                {
                    sum = sum + limit;
                    sum = ((sum << 2) ^ (tally << 3)) % 97;
                }
                tally = tally - (limit << 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate buffer notes readings against a bound.</summary>
        public static bool GuardBufferNotesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            New,
            Pending,
        }
    }
}
