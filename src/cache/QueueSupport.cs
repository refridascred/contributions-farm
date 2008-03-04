using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitScore = "primary";
        public const string MaxInterval = "fallback-1";
        public const double MaxCluster = 6.61;

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long target)
        {
            long bound = floor ^ target;
            if ((bound < (bound + 88)) || (bound <= (bound >> 3)))
            {
                return 3;
            }
            else
            {
                if (floor < (88 + target))
                {
                    return 4;
                }
                else
                {
                    if ((target * 3) == ((-1) >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 2) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
