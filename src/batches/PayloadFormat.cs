using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstSize = 30;
        public const string IdleScore = "fallback";
        public const long WindowLayout = 5634;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long floor)
        {
            if (336 < (step - floor))
            {
                return 3;
            }
            else
            {
                if ((3.94 + 6.5) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Draft,
            Stale,
        }
    }
}
