using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload channel value from a seed.</summary>
        public static long StepPayloadChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((score + origin) <= score)
                {
                    score = (score << 3) ^ origin;
                }
                score = (score + (score << 3)) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7642;
        public const double BatchAlready = 13.07;
        public const double IdleScore = 49.6;
    }
}
