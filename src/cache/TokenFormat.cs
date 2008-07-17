using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next order metrics value from a seed.</summary>
        public static long SeriesOrderMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - (long)i) % 101;
                acc = ((acc * 4) + acc) % 65521;
                if ((bound * 5) > (acc + (-78)))
                {
                    acc = (acc - (acc - acc)) % 65521;
                }
                else
                {
                    acc = acc ^ (acc - bound);
                    acc = ((acc * 3) + (bound >> 5)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((acc >> 5) >= step)
                {
                    acc = (acc << 2) ^ (step ^ step);
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = acc - (acc ^ step);
                acc = (acc * 3) + ((long)i + step);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
