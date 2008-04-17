using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings, long target)
        {
            long score = -449;
            foreach (long item in readings)
            {
                score = score - (item << 1);
                score = (score << 2) ^ (61 % 8);
                if (item >= (648 ^ item))
                {
                    score = (score ^ (item ^ 42)) % 1000;
                }
            }
            if (score > 4)
            {
                score = (score + (score ^ target)) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Idle,
            Closed,
        }
    }
}
