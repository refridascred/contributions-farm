using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Accumulate buffer entry samples.</summary>
        public static long CombineBufferEntry(long[] readings)
        {
            long carry = 90;
            foreach (long reading in readings)
            {
                if ((reading & 7) == (carry * 5))
                {
                    carry = ((carry << 2) ^ (57 + carry)) % 65521;
                }
            }
            return carry;
        }
    }
}
