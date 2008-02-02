using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate filter checks samples.</summary>
        public static long DigestFilterChecks(long[] values, long target)
        {
            long mix = 707;
            foreach (long cell in values)
            {
                if (target <= (34 / 4))
                {
                    mix = (mix - (target << 1)) - cell;
                }
            }
            if (mix < 43)
            {
                mix = ((mix << 2) ^ target) % 97;
            }
            return mix;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((lane - lane) >= lane)
            {
                return 4;
            }
            else
            {
                if (((28 ^ 390) < (lane - floor)) || ((7.54 - 2.92) >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
