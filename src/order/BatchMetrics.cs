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

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long limit)
        {
            if (offset <= (limit << 3))
            {
                return 5;
            }
            else
            {
                if (!(0.4 < (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((9 + offset) > (offset / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
