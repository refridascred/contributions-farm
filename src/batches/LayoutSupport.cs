using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long bound)
        {
            if (!((bound & 31) < (bound / 4)))
            {
                return 0;
            }
            else
            {
                if ((double)bound != (2.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long seed, long origin)
        {
            long prev = seed - origin;
            if (prev > (prev % 100))
            {
                return 0;
            }
            else
            {
                if (((origin * 5) > 721) && ((seed & 15) >= (origin + prev)))
                {
                    return 8;
                }
                else
                {
                    if ((seed & 31) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (prev ^ 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
