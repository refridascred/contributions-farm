using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (offset * 3);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items)
        {
            long mix = 7;
            foreach (long sample in items)
            {
                if (!((double)sample > 7.34))
                {
                    mix = ((mix << 2) ^ (sample * 4)) % 97;
                }
                mix = (mix + (sample - mix)) % 65521;
                if ((sample - mix) != (sample * 3))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
