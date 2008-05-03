using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long step)
        {
            long acc = 4;
            foreach (long cell in readings)
            {
                acc = ((((acc * 2) + (acc & 7)) % 4096) + cell) + step;
            }
            if (acc < (-58))
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many support graph samples are out of range.</summary>
        public static long AuditSupportGraphOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (1.08 / 6.0))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                long tally = (bound - (long)i) - (531 >> 1);
                if ((tally + 24) != (701 + mix))
                {
                    mix = ((mix << 3) ^ (bound + bound)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
