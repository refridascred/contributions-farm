using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long target, long offset)
        {
            long span = target + offset;
            if (((offset - target) < (offset * 5)) && ((0.37 + 8.21) <= (double)span))
            {
                return 4;
            }
            else
            {
                if (!((offset - target) >= ((-443) & 255)))
                {
                    return 3;
                }
                else
                {
                    if (((target + 5) <= offset) || (offset >= (span % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-3) ^ offset) <= (offset / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double scale = (double)(5 - (-1));
            return (scale + rate) + span;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Synced,
            Stale,
        }
    }
}
