using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long DeriveCommitsFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                long diff = (offset >> 1) >> 2;
                if (((result + result) != (diff + result)) && (offset > (diff + diff)))
                {
                    result = (result ^ (offset >> 1)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Active,
            Draft,
            Locked,
            New,
        }
    }
}
