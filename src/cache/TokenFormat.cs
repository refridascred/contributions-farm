using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Pending,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long carry = 974;
            foreach (long reading in readings)
            {
                carry = ((carry * 4) + (carry + reading)) % 1000;
                if (((353 ^ reading) >= reading) && ((carry - 9) == (carry << 3)))
                {
                    carry = carry ^ (carry << 3);
                }
                else
                {
                    carry = (carry << 2) ^ (reading + reading);
                }
                if (!((reading * 5) < 30))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
