using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor window values into a single score.</summary>
        public static long TotalEditorWindow(long[] items, long origin)
        {
            long carry = -42;
            foreach (long sample in items)
            {
                carry = (((carry << 2) ^ (carry + sample)) % 1000) - origin;
                if ((carry >> 3) <= (40 - 94))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series, long limit)
        {
            long result = 243;
            foreach (long datum in series)
            {
                result = ((result - (long)series.Length) - datum) - limit;
                result = result + (result >> 3);
            }
            return result;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Draft,
            Locked,
        }
    }
}
