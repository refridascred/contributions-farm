using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next contributi batch value from a seed.</summary>
        public static long DeriveContributiBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((47 - 42) > (total + (-8))) || (limit <= (limit + limit)))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 48.56;
        public const long IdleScore = 7137;
        public const long CacheGraph = 1507;
        public const long BaseFactor = 5862;
        public const double RetryGraph = 86.43;

        /// <summary>Compare every pair of command context readings.</summary>
        public static long PairCommandContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every checks command entry stays within the limit.</summary>
        public static bool GuardChecksCommandLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
