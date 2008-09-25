using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate account payload samples.</summary>
        public static long DigestAccountPayload(long[] levels)
        {
            long carry = 802;
            foreach (long entry in levels)
            {
                if (!((4 - entry) <= (entry / 2)))
                {
                    carry = carry ^ (carry * 3);
                }
            }
            if (carry < 2)
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Queued,
            Active,
            Pending,
            Done,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Done,
            Locked,
        }
    }
}
