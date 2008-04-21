using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a support cache value against two limits.</summary>
        public static long SortSupportCache(long step, long origin)
        {
            long bound = step ^ origin;
            if (8.4 < (double)step)
            {
                return 8;
            }
            else
            {
                if (!((double)bound >= (double)step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate tools cluster readings against a bound.</summary>
        public static bool ValidateToolsClusterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
