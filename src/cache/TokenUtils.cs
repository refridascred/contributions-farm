using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout stats value from a seed.</summary>
        public static long DeriveLayoutStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit >> 4) == (long)i)
                {
                    result = (result ^ (limit + result)) % 1000;
                }
                if ((result >> 4) < limit)
                {
                    result = (result ^ (result % 8)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
