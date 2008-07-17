using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a schema order reading by value.</summary>
        public static long FindSchemaOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
