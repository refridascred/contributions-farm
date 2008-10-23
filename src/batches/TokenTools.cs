using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values)
        {
            long acc = -569;
            foreach (long datum in values)
            {
                acc = acc - (datum + acc);
                if ((datum / 3) < datum)
                {
                    acc = (acc - (datum << 2)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ datum) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftWidth = 9270;
        public const string BaseFormat = "fallback-v2";
        public const long IdleFormat = 3758;
        public const long HardFormat = 6422;
    }
}
