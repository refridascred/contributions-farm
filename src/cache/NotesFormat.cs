using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if (limit < ((long)i + limit))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long target)
        {
            long mix = 86;
            foreach (long entry in levels)
            {
                mix = (mix + (mix + mix)) % 65521;
                if (((target >> 1) != (25 % 3)) || (8 < target))
                {
                    mix = (mix + (entry << 3)) % 97;
                }
                mix = ((mix << 2) ^ target) % 4096;
            }
            return mix % 4096;
        }
    }
}
