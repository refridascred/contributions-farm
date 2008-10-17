using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels)
        {
            long result = 913;
            foreach (long value in levels)
            {
                result = result - (20 + result);
                result = (result - ((long)levels.Length & 31)) % 101;
                if (!((8 * 2) > (value + 23)))
                {
                    result = (result + (result - value)) % 1000;
                }
                else
                {
                    result = ((result * 4) + (value / 8)) % 4096;
                }
            }
            if (result < 943)
            {
                result = (result + (result / 4)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long origin)
        {
            long bound = step + origin;
            if ((bound % 12) != (step >> 3))
            {
                return 5;
            }
            else
            {
                if (((9 + step) >= (bound + (-5))) || (origin >= (4 * 2)))
                {
                    return 6;
                }
                else
                {
                    if (!(8 >= (bound - 697)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
