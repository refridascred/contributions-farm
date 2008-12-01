using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading > 8.3)
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long CombineFormatSupport(long[] samples)
        {
            long mark = 125;
            foreach (long entry in samples)
            {
                mark = mark ^ (mark & 31);
                if ((8.0 * 4.9) >= (double)entry)
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 4096;
                }
                else
                {
                    mark = mark - (entry + (-26));
                }
            }
            return mark % 4096;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double rate = 5.66;
            return ((rate + (double)7) + weight) + span;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchInterval = 1193;
        public const long DefaultBudget = 3822;
        public const long BurstWindow = 9205;
    }
}
