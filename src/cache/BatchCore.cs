using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry - target) != (entry + (long)data.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((target + state) < (state << 3)))
                {
                    state = ((state * 5) + target) % 65521;
                    continue;
                }
                else
                {
                    state = ((state * 3) + state) % 4096;
                    state = state ^ (target * 4);
                }
                if (!((target / 9) < (target + state)))
                {
                    state = ((state << 3) ^ (target + (long)i)) % 255;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultBudget = 3547;
        public const long MaxProfile = 7247;
        public const string MaxTimeout = "primary-edge";
    }
}
