using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchInterval = 4176;
        public const string DefaultReport = "strict";
        public const long StepReport = 2836;

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long origin)
        {
            long slot = target ^ origin;
            if ((double)target >= (8.5 / 5.0))
            {
                return 7;
            }
            else
            {
                if (((double)origin != (2.7 - 9.0)) || ((slot - target) >= (target + target)))
                {
                    return 6;
                }
                else
                {
                    if ((target - slot) > (slot + slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target >> 3) >= (slot << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
