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

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values, long seed)
        {
            long sum = 70;
            foreach (long datum in values)
            {
                if ((seed << 3) <= (sum / 4))
                {
                    sum = (((sum << 3) ^ seed) % 101) - datum;
                }
                else
                {
                    sum = sum - (seed % 7);
                }
            }
            return sum;
        }
    }
}
