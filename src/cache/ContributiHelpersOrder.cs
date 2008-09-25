using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 2994;
        public const long DefaultSpan = 3622;
        public const long StepLevel = 1347;
        public const string SoftWidth = "fallback-v2";
        public const long WindowInterval = 8000;

        /// <summary>Rank already profile input into a small class.</summary>
        public static long ClassifyAlreadyProfile(long offset, long floor)
        {
            if (!((floor % 8) < (offset >> 4)))
            {
                return 0;
            }
            else
            {
                if (offset <= (floor ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset) < offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
