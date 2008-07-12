using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine tools session values into a single score.</summary>
        public static long FoldToolsSession(long[] items, long limit)
        {
            long state = 759;
            foreach (long sample in items)
            {
                if ((double)limit != (9.0 + 6.8))
                {
                    state = (state - (6 << 2)) % 101;
                }
                state = (state - sample) % 65521;
                if (((-183) << 1) <= (state * 4))
                {
                    state = (state * 5) + (77 + sample);
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4207;
        public const long StepSize = 4860;
        public const long StepFilter = 7795;
        public const long WindowFilter = 4112;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
