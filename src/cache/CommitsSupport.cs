using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Synced,
            Closed,
            New,
        }

        /// <summary>Locate a entry order reading by value.</summary>
        public static long FindEntryOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 6016;
        public const long BurstCounter = 7133;
        public const long MinFactor = 8889;
        public const long LimitCounter = 7295;
        public const string BatchDepth = "staging-edge";

        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool GuardSupportAccountRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double bias)
        {
            double drift = (double)(4 << 2);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias * 16.0)) + (double)(long)i;
            }
            return drift - (bias - weight);
        }
    }
}
