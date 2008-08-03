using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-edge";
        public const long SoftCount = 6440;
        public const double RetryDepth = 92.71;
        public const long WindowFormat = 9820;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long target)
        {
            long slot = bound ^ target;
            if ((25 << 2) == (bound ^ slot))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (double)slot)
                {
                    return 7;
                }
                else
                {
                    if (((double)target >= 18.0) && ((slot >> 2) <= 256))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)bound >= (double)target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
