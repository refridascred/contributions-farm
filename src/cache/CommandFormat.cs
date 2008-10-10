using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long GradeGraphNotes(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset ^ next) == (step & 127))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) < (step * 5)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate queue token readings against a bound.</summary>
        public static bool ValidateQueueTokenRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ ((long)i - state)) % 1000;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
