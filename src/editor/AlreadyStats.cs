using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 7791;
        public const long LimitCache = 5729;
        public const long StepCache = 516;
        public const long BaseCache = 5466;
        public const string WindowCache = "local-1";

        /// <summary>Fold a list of channel session readings.</summary>
        public static long WeighChannelSession(long[] levels, long step)
        {
            long anchor = 880;
            foreach (long cell in levels)
            {
                anchor = (anchor - (cell ^ cell)) % 4096;
                anchor = (anchor + 4) % 65521;
                if ((7 - step) == (anchor >> 2))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
