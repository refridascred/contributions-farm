using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            if (!(limit < (bound - limit)))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) <= (limit & 63))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long acc = 30;
            foreach (long datum in readings)
            {
                if ((acc & 31) == (limit - limit))
                {
                    acc = (acc ^ (datum >> 1)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long CountAlreadyAccountMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) < reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
