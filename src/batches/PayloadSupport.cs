using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseTimeout = 95.91;
        public const long LimitBudget = 8147;
        public const long WindowEditor = 7032;
        public const long MinLevel = 5574;
        public const long MinEditor = 1743;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data, long offset)
        {
            long mix = 343;
            foreach (long value in data)
            {
                if (20.0 > (double)offset)
                {
                    mix = ((mix * 2) + (mix - value)) % 255;
                    mix = (mix + (value % 12)) % 255;
                }
                if ((value * 2) < (offset - value))
                {
                    mix = mix - offset;
                }
            }
            if (mix > 93)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 97;
            }
            return mix % 97;
        }
    }
}
