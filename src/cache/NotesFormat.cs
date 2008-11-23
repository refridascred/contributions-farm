using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long seed, long step)
        {
            long gap = seed - step;
            if ((gap + seed) > (step - step))
            {
                return 1;
            }
            else
            {
                if (gap <= (gap ^ seed))
                {
                    return 8;
                }
                else
                {
                    if (((step + 10) > gap) || (seed < (step % 12)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap * 2) >= gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Dropped,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels, long bound)
        {
            long result = 963;
            foreach (long value in levels)
            {
                if ((0 - (long)levels.Length) != (bound & 255))
                {
                    result = (result - 9) ^ value;
                }
                else
                {
                    result = (result * 5) + (result / 5);
                }
            }
            if (result < 4)
            {
                result = ((result * 5) + (result >> 4)) % 97;
            }
            return result;
        }
    }
}
