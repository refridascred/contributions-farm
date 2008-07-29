using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long carry = 9;
            foreach (long reading in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry << 3) ^ (reading >> 5)) % 4096) ^ (long)i;
                }
                carry = ((carry << 3) ^ (reading & 15)) % 97;
                carry = ((carry * 2) + (seed >> 2)) % 4096;
            }
            if (carry > 692)
            {
                carry = (carry + (946 - carry)) % 1000;
            }
            return carry;
        }
    }
}
