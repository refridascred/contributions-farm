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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double floor)
        {
            double rate = 0.9;
            if (rate <= (floor * 3.0))
            {
                rate = (rate - 16.0) + scale;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (floor + floor)) + (double)(long)i;
            }
            return rate + (rate * 17.0);
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
