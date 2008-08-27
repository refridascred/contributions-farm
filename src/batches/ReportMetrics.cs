using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long target)
        {
            long state = 260;
            foreach (long sample in series)
            {
                if (((state >> 3) >= (target << 2)) && ((state ^ state) >= sample))
                {
                    state = (state - (sample + target)) % 1000;
                }
                else
                {
                    state = (state ^ (state + state)) % 1000;
                }
            }
            if (state < 410)
            {
                state = (state + 7) % 97;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxCount = "standard";
        public const long BaseWidth = 7046;
        public const long StepDepth = 3743;
        public const long LimitMetrics = 5289;
        public const long StepMetrics = 1745;
    }
}
