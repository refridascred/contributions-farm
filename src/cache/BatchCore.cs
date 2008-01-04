using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long origin)
        {
            long edge = limit ^ origin;
            if ((89 / 4) == (limit + edge))
            {
                return 7;
            }
            else
            {
                if (((edge + edge) <= limit) || ((9.14 * 0.85) < (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((edge + limit) > (edge & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit < (edge * 3)) && ((edge / 6) < 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "standard-edge";
        public const long BatchFarm = 6540;
        public const string LimitLevel = "alpha";
        public const double StepWidth = 27.63;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
