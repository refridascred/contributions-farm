using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state - (97 * 3);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long FoldAccountMetric(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if ((3 & 3) > (datum + state))
                {
                    state = (state << 3) ^ (datum ^ datum);
                }
                else
                {
                    state = (state + (state & 63)) % 97;
                }
            }
            if (state > 6)
            {
                state = (state * 3) + state;
            }
            return state;
        }
    }
}
