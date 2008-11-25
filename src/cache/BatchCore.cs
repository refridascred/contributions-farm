using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine filter schema values into a single score.</summary>
        public static long DigestFilterSchema(long[] samples, long origin)
        {
            long state = 49;
            foreach (long sample in samples)
            {
                if ((4 - sample) > (sample & 63))
                {
                    state = (state ^ (68 ^ 613)) - origin;
                    continue;
                }
                state = (state - (state >> 2)) % 4096;
            }
            return state;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(mix >= ((long)i - seed)))
                {
                    mix = mix ^ ((long)i + mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 97;
                }
                if ((double)mix > (3.34 + 4.0))
                {
                    mix = (mix + seed) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((limit << 2) <= 492)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
