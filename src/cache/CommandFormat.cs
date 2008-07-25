using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches > (sample >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if (18.0 > (double)mark)
                {
                    mark = ((mark * 5) + (415 ^ mark)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Idle,
            Draft,
            Active,
            New,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mix = 520;
            foreach (long entry in samples)
            {
                mix = ((mix * 4) + mix) ^ entry;
            }
            return mix;
        }
    }
}
