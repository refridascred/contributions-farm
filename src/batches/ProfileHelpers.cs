using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] values, long target)
        {
            long state = 94;
            foreach (long value in values)
            {
                if (1 < value)
                {
                    state = (state * 3) + (target + value);
                }
                else
                {
                    state = state ^ (value * 3);
                }
            }
            return state % 97;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            if ((limit - limit) <= limit)
            {
                return 3;
            }
            else
            {
                if ((26 / 4) != (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound != (5.2 - 8.44)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double weight = bias;
            return weight - (2.15 - scale);
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
