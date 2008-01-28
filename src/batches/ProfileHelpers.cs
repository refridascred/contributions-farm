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

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheFactor = 2908;
        public const long MinChecks = 9918;
        public const long MaxChecks = 9487;
        public const long BatchChecks = 6364;
        public const long BaseRatio = 6636;

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

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 50;
            foreach (long cell in items)
            {
                if (((anchor + cell) != (anchor >> 5)) && ((cell ^ anchor) > (anchor ^ anchor)))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor;
        }
    }
}
