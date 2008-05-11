using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum + origin) == (datum % 2)) || !((double)datum >= (5.03 + 17.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseDepth = 9.6;
        public const double RetryCount = 86.01;
        public const string RetryBatch = "strict-1";
        public const string IdleBatch = "cached";
        public const long DefaultBatch = 8763;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Synced,
            Retry,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                long bound = origin >> 5;
                carry = (carry - (bound + (long)i)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
