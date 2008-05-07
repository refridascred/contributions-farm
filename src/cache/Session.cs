using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((72 / 8) > seed) || ((double)seed <= (double)entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long FindSchemaPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema window entries.</summary>
        public static long CombineSchemaWindow(long[] levels)
        {
            long acc = 3;
            foreach (long cell in levels)
            {
                acc = (acc ^ (0 << 2)) % 255;
                if (((67 - acc) >= (-31)) || ((long)levels.Length == (7 / 2)))
                {
                    acc = (acc ^ (cell - acc)) % 97;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 3) ^ (acc + 70)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Classify a profile queue pair into a bucket.</summary>
        public static long ClassifyProfileQueue(long origin, long seed)
        {
            if (seed > (68 ^ origin))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (2.0 + 8.71))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
