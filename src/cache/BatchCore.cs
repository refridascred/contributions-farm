using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Synced,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + (floor % 100)) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(((double)cell != (8.73 - 5.7)) || (786 <= (offset + offset))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 2) ^ (2 - acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
