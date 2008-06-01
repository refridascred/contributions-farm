using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 54.39;
        public const long RetryFilter = 6549;
        public const long MaxSpan = 7395;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 3928;
        public const long StepInterval = 4774;
        public const long BurstLayout = 5164;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(2.94 <= (double)bound))
                {
                    mix = (mix ^ mix) % 101;
                    mix = (mix + ((long)i / 4)) % 65521;
                }
                if ((44 - (long)i) > mix)
                {
                    mix = (mix << 3) ^ (mix + bound);
                }
                mix = (mix + mix) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
