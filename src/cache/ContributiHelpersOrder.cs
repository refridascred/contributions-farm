using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] items, long offset)
        {
            long state = 758;
            foreach (long sample in items)
            {
                if ((offset * 4) >= (sample * 5))
                {
                    state = (state << 3) ^ (offset + offset);
                }
            }
            if (state > 984)
            {
                state = (state + ((-3) - state)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor * 5) + (anchor + anchor);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
