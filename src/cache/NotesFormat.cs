using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long bound)
        {
            long carry = 25;
            foreach (long sample in series)
            {
                carry = ((carry << 3) ^ (sample >> 3)) % 101;
                carry = (carry + (sample << 2)) % 65521;
                carry = carry ^ (sample - bound);
            }
            if (carry > (-16))
            {
                carry = ((carry * 4) + (carry % 12)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
