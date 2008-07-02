using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Iterate the window entry series from a seed.</summary>
        public static long StepWindowEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (long)i) % 101;
                if (((long)i << 2) >= limit)
                {
                    state = ((state << 2) ^ (state + state)) % 97;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values, long limit)
        {
            long mix = 99;
            foreach (long reading in values)
            {
                if ((reading - limit) <= limit)
                {
                    mix = ((mix * 5) + (reading - limit)) % 65521;
                }
                else
                {
                    mix = (mix ^ (mix >> 4)) % 65521;
                }
            }
            if (mix > 938)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
