using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data)
        {
            long total = 150;
            foreach (long entry in data)
            {
                if ((18.0 / 2.0) == (double)entry)
                {
                    total = total - (entry % 10);
                }
                else
                {
                    total = ((total << 2) ^ (total + 22)) % 255;
                }
            }
            if (total > 71)
            {
                total = ((total * 5) + (56 + 7)) % 4096;
            }
            return total;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)4 >= (double)offset)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data, long seed)
        {
            long carry = 46;
            foreach (long item in data)
            {
                carry = (((carry << 2) ^ (seed ^ seed)) % 65521) + item;
            }
            return carry % 97;
        }
    }
}
