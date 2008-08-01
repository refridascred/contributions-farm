using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target - anchor) > target)
                {
                    anchor = anchor - (target - anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long CombineGraphSchema(long[] readings)
        {
            long anchor = 9;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 5) + (entry * 2)) % 4096;
            }
            if (anchor < 82)
            {
                anchor = (anchor + (570 + 71)) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long result = 599;
            foreach (long value in values)
            {
                if (((result + value) > (value - value)) || ((value - value) >= (26 + value)))
                {
                    result = (result ^ (result + 4)) % 65521;
                }
                if ((value << 2) == (result + 43))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
