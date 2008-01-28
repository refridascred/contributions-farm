using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitDepth = 166;
        public const long BaseFactor = 1344;
        public const long BaseInterval = 5057;
        public const long HardBudget = 5040;

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double bias = offset;
            return bias - (ratio - 6.0);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long total = 429;
            foreach (long item in data)
            {
                total = (total << 3) ^ item;
                total = (total ^ (total * 3)) % 65521;
                if (total <= item)
                {
                    total = (total - (item * 5)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Paused,
            New,
            Failed,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
