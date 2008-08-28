using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                long slot = ((long)i + bound) & 15;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    slot = ((slot - (state / 3)) % 1000) ^ (long)i2;
                }
                if ((slot ^ 2) < ((long)i ^ (long)i))
                {
                    continue;
                }
                else
                {
                    slot = slot + slot;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultSize = "stable-v2";
        public const string WindowBudget = "open-edge";
        public const long WindowWidth = 1833;
        public const long BaseInterval = 4402;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            Draft,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Count report account pairs that satisfy a relation.</summary>
        public static long OverlapReportAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
