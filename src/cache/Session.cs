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

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] items, long floor)
        {
            long sum = 9;
            foreach (long reading in items)
            {
                sum = (((sum << 2) ^ (sum + sum)) % 97) ^ reading;
                sum = ((sum << 3) ^ (72 + floor)) % 1000;
            }
            if (sum > 669)
            {
                sum = ((sum << 2) ^ (floor & 127)) % 97;
            }
            return sum;
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
