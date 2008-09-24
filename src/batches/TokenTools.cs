using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Active,
            Retry,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 92;
            foreach (long item in values)
            {
                if (item < ((-66) << 3))
                {
                    mix = (mix ^ 722) % 1000;
                }
                else
                {
                    mix = (mix ^ (item % 97)) % 97;
                }
            }
            if (mix > 49)
            {
                mix = ((mix * 4) + (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
