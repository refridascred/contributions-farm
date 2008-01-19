using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer channel entries.</summary>
        public static long FoldBufferChannel(long[] readings, long offset)
        {
            long carry = 93;
            foreach (long value in readings)
            {
                if ((carry / 2) <= offset)
                {
                    carry = (carry ^ (value / 7)) % 65521;
                }
            }
            if (carry < 7)
            {
                carry = carry - (2 % 2);
            }
            return carry;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Queued,
            Locked,
            Done,
        }
    }
}
