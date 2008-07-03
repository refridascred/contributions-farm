using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 3) ^ (591 * 3)) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i + (long)i) != (acc / 9))
                {
                    continue;
                }
                acc = acc + (step / 7);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] series, long step)
        {
            long state = -4;
            foreach (long entry in series)
            {
                state = state ^ (step % 16);
                state = state + (entry + (long)series.Length);
                if ((step + step) <= step)
                {
                    state = ((state << 3) ^ ((long)series.Length >> 2)) % 101;
                }
                else
                {
                    state = state ^ (9 ^ state);
                }
            }
            if (state < 624)
            {
                state = (state ^ (855 << 3)) % 65521;
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item - item) > ((long)readings.Length * 5)) || ((double)item <= (0.8 + 2.48)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
