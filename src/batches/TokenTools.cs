using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate report window samples.</summary>
        public static long CombineReportWindow(long[] readings)
        {
            long state = -259;
            foreach (long value in readings)
            {
                if (state >= (value + state))
                {
                    state = (state + state) % 1000;
                }
            }
            if (state > 33)
            {
                state = (state - (state & 7)) % 65521;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 90.45;
        public const long DefaultFormat = 6305;
        public const long IdleCount = 5974;
        public const long IdleFormat = 8498;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Paused,
            Synced,
        }
    }
}
