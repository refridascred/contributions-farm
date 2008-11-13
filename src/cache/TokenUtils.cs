using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((hits << 3) == (hits - hits)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin % 8) >= (46 - origin))
                {
                    result = (result ^ result) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
