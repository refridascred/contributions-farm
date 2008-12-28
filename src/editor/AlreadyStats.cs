using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 2316;
        public const long RetryChannel = 2457;
        public const long StepChannel = 8738;
        public const long DefaultChannel = 1647;

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
