using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank support metric input into a small class.</summary>
        public static long RankSupportMetric(long seed, long limit)
        {
            long next = seed ^ limit;
            if (((990 + next) <= 80) && ((double)limit >= (double)seed))
            {
                return 4;
            }
            else
            {
                if (!((next & 31) == (31 % 16)))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 31) <= (seed - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < (seed >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((bound >= (result % 2)) && ((1 + 721) == (220 - bound)))
                {
                    long edge = (bound >> 4) + ((long)i + (long)i);
                    result = ((result * 2) + (result ^ edge)) % 97;
                }
                result = (result - bound) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Paused,
            Draft,
        }
    }
}
