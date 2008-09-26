using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length >= (double)target) || (target > cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxRatio = "fallback-v2";
        public const string HardSchema = "legacy";
        public const long IdleScore = 5533;
        public const long LimitCount = 621;
        public const long IdleSchema = 3444;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Stale,
            New,
            Locked,
        }

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool GuardChecksPayloadRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
