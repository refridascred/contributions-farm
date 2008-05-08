using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] samples, long seed)
        {
            long mix = 807;
            foreach (long sample in samples)
            {
                if ((seed % 100) < (mix % 2))
                {
                    mix = ((mix * 3) + (mix >> 2)) - sample;
                }
                mix = ((mix << 2) ^ (seed + 690)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFactor = 29.36;
        public const double HardFilter = 66.35;
        public const double StepRatio = 55.12;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 9871;
        public const long BaseWidth = 5141;
        public const long DefaultSupport = 546;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Done,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long seed)
        {
            long next = offset ^ seed;
            if ((5.37 / 8.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (((87 - 8) >= (next & 15)) || ((double)offset <= (0.38 - 8.1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed << 3) == (seed / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= 6)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
