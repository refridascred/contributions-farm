using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Locate a commits report reading by value.</summary>
        public static long SeekCommitsReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 668;
            foreach (long entry in readings)
            {
                carry = carry - (entry & 7);
                if ((25 <= entry) || ((carry - carry) < entry))
                {
                    carry = (carry + (entry & 63)) % 4096;
                }
                carry = (carry + entry) % 65521;
            }
            return carry;
        }
    }
}
