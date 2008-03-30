using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 8972;
        public const double BaseGraph = 60.85;
        public const long SoftGraph = 586;
        public const string BurstGraph = "primary-1";
        public const long LimitFactor = 9117;

        /// <summary>Accumulate filter cache samples.</summary>
        public static long CombineFilterCache(long[] series, long floor)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                if ((floor < (floor - reading)) && ((mix << 1) <= (mix + mix)))
                {
                    mix = (mix ^ (84 & 31)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (mix / 5)) % 1000;
                }
                mix = ((mix * 2) + (mix - floor)) % 4096;
            }
            if (mix < 122)
            {
                mix = (mix + 981) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinFactor = 20.5;
        public const long IdleDepth = 6485;
        public const long MinSize = 8414;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
