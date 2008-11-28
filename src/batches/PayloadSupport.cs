using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long sum = 817;
            foreach (long reading in data)
            {
                sum = (sum + (195 / 5)) % 101;
                if ((reading & 63) > (sum / 7))
                {
                    sum = ((sum << 2) ^ (sum - reading)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell / 2) >= (cell - offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count account context pairs that satisfy a relation.</summary>
        public static long CompareAccountContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
