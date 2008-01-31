using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5919;
        public const long MinFilter = 1404;
        public const string WindowFilter = "latest-1";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((9.0 / 5.0) <= (double)seen) || ((reading + (long)values.Length) == (seen + 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long target)
        {
            long gap = origin + target;
            if ((0 ^ 46) != (gap % 97))
            {
                return 4;
            }
            else
            {
                if (1 <= (target - origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long WeighToolsReport(long[] items, long origin)
        {
            long score = 839;
            foreach (long reading in items)
            {
                if ((reading <= (reading + score)) || (reading <= origin))
                {
                    score = (score + (898 / 9)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Synced,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "local-1";
        public const string IdleAlready = "alpha-v2";
        public const string BaseFactor = "standard-edge";
        public const long DefaultFactor = 1579;
        public const long DefaultAlready = 4154;
    }
}
