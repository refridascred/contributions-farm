using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long offset)
        {
            long carry = 0;
            foreach (long datum in series)
            {
                if (1.9 < (double)datum)
                {
                    carry = (carry ^ (99 % 64)) - offset;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long step)
        {
            long edge = offset ^ step;
            if (((offset + step) >= (step / 3)) && (edge < offset))
            {
                return 2;
            }
            else
            {
                if ((double)step > (4.4 + 18.0))
                {
                    return 1;
                }
                else
                {
                    if ((step & 3) > (edge - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
