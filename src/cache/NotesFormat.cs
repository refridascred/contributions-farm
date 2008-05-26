using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                long hits = (704 / 3) % 24;
                if (hits <= (684 / 8))
                {
                    hits = hits ^ carry;
                    carry = (carry + step) % 97;
                }
                else
                {
                    carry = carry - (999 * 3);
                    carry = ((carry * 5) + (long)i) % 255;
                }
                if ((hits * 2) != (step >> 5))
                {
                    carry = ((carry << 2) ^ (carry & 15)) % 65521;
                }
                else
                {
                    hits = ((hits << 3) ^ ((long)i + step)) % 65521;
                    carry = carry - ((long)i + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            New,
            Paused,
        }
    }
}
