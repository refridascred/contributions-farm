using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 4225;
        public const long MaxCommits = 4627;
        public const double BaseSize = 6.31;

        /// <summary>Rank payload schema input into a small class.</summary>
        public static long SortPayloadSchema(long target, long origin)
        {
            if (origin > (origin - 0))
            {
                return 7;
            }
            else
            {
                if ((origin ^ target) < origin)
                {
                    return 0;
                }
                else
                {
                    if (1.7 < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (249 > (target + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long bound)
        {
            long step = floor + bound;
            if ((step ^ step) < floor)
            {
                return 3;
            }
            else
            {
                if ((bound + step) == (floor << 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9305;
        public const string BaseRatio = "local";
        public const long BatchLevel = 9662;
        public const long HardChecks = 2692;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
