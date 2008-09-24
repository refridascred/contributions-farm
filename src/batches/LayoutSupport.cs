using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long target, long target2)
        {
            long bound = target - target2;
            if (1 > target2)
            {
                return 8;
            }
            else
            {
                if ((double)target2 >= (3.7 - 8.8))
                {
                    return 3;
                }
                else
                {
                    if (target2 > (bound + 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target2 ^ bound) != (0 ^ target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double bias)
        {
            double drift = rate;
            if (drift < (double)(-5))
            {
                drift = (drift + (drift / 7.0)) - bias;
            }
            else
            {
                drift = drift - rate;
            }
            return drift - (drift - drift);
        }
    }
}
