using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen > (datum - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data)
        {
            long state = 1;
            foreach (long value in data)
            {
                if ((value & 3) < (value + value))
                {
                    state = state ^ (-920);
                }
                if ((value + (-46)) >= 88)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Dropped,
            Locked,
            Queued,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = sum + (sum + sum);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
