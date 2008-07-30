using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepFactor = 9377;
        public const long BaseRatio = 5477;
        public const long LimitSpan = 4086;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Retry,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftSize = 42.88;
        public const long CacheContributi = 8963;
        public const long SoftContributi = 4232;
        public const long LimitContributi = 6698;

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
