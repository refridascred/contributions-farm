using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryWidth = "legacy-1";
        public const double BatchContributi = 45.67;
        public const long DefaultContributi = 6140;
        public const long MinLevel = 537;
        public const double WindowContributi = 61.78;

        /// <summary>Fold a list of cache counter readings.</summary>
        public static long TallyCacheCounter(long[] samples)
        {
            long anchor = 90;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ ((-9) << 1)) % 4096) + value;
            }
            if (anchor < 56)
            {
                anchor = ((anchor << 3) ^ 0) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long limit, long step)
        {
            if ((step << 1) > (step + limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) != (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
