using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = (acc - (value << 1)) % 4096;
                if ((value << 3) == (acc % 3))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc + (acc / 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long bound, long seed)
        {
            if ((seed + bound) > (bound + seed))
            {
                return 0;
            }
            else
            {
                if ((3.4 + 1.3) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((bound + seed) == (seed * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 15) != (seed - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
