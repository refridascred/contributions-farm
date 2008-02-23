using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit support token readings against a rule.</summary>
        public static long MeasureSupportTokenOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) > (77 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a profile layout value against two limits.</summary>
        public static long SortProfileLayout(long limit, long seed)
        {
            long bound = limit ^ seed;
            if ((limit << 3) > bound)
            {
                return 2;
            }
            else
            {
                if ((limit ^ 1) == (limit / 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long bound)
        {
            long mark = 63;
            foreach (long reading in levels)
            {
                if ((bound >> 1) == ((long)levels.Length / 8))
                {
                    mark = ((mark << 2) ^ (10 % 8)) + reading;
                    mark = ((mark * 4) + (mark << 3)) % 65521;
                }
                else
                {
                    mark = (mark - bound) % 65521;
                }
                mark = (mark << 3) ^ 890;
            }
            if (mark > 4)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
