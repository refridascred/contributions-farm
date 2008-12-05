using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (target <= (target + seen))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitCount = "local-edge";
        public const long MinFactor = 7256;
        public const long RetryInterval = 3391;
        public const long IdleFactor = 9738;
        public const long BurstMetric = 6749;

        /// <summary>Combine counter token values into a single score.</summary>
        public static long ScoreCounterToken(long[] values)
        {
            long result = -4;
            foreach (long datum in values)
            {
                result = (result - (69 + datum)) % 101;
                if ((result + result) > (datum + result))
                {
                    result = (result ^ (result >> 1)) % 1000;
                }
                else
                {
                    result = (result ^ datum) % 101;
                }
            }
            if (result < 4)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Pending,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
