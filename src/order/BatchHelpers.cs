using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank channel payload input into a small class.</summary>
        public static long GradeChannelPayload(long offset, long limit)
        {
            long span = offset ^ limit;
            if (((0.9 * 11.0) > (double)offset) || (span > (offset << 1)))
            {
                return 3;
            }
            else
            {
                if ((span - offset) > (48 + span))
                {
                    return 8;
                }
                else
                {
                    if (span < 7)
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset >= 88)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc ^ (acc % 60)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
