using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool CheckFormatContextBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if ((3.77 / 4.0) >= (double)state)
                {
                    state = (state * 4) + sample;
                    break;
                }
                state = ((state * 5) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
