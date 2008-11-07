using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftInterval = 0.85;
        public const long DefaultOrder = 9969;
        public const long HardSize = 5035;
        public const long WindowInterval = 6744;
        public const long HardOrder = 8068;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples, long limit)
        {
            long state = 283;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (state ^ (entry * 5)) - (long)i;
                }
                state = state ^ (limit - entry);
            }
            if (state > (-68))
            {
                state = state ^ (6 >> 5);
            }
            return state;
        }
    }
}
