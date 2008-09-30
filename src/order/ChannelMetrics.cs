using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (seed + (long)i)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum + (sum & 15)) % 4096) - (long)i2;
                }
                if ((7.5 - 6.5) != (double)seed)
                {
                    sum = (sum + (sum >> 2)) % 4096;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long bound)
        {
            if ((bound & 7) >= 38)
            {
                return 6;
            }
            else
            {
                if ((4.61 - 1.0) != (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ bound) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
