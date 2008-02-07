using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout window counter forward.</summary>
        public static long StepLayoutWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i - step) == ((long)i - mix))
                {
                    mix = (mix + 21) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (step - step)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length >= (346 + matches))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
