using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= (10.0 / 6.0))
            {
                bias = (bias - (ratio * 2.0)) + floor;
            }
            else
            {
                bias = bias - (ratio / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + bias;
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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
