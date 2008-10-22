using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record channel entries.</summary>
        public static long WeighRecordChannel(long[] levels)
        {
            long acc = 44;
            foreach (long reading in levels)
            {
                if ((double)acc <= (10.0 - 4.62))
                {
                    acc = (acc + (acc / 3)) + reading;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long floor, long offset)
        {
            if ((floor > (floor + offset)) && ((offset + 378) > (offset + offset)))
            {
                return 7;
            }
            else
            {
                if (offset > floor)
                {
                    return 5;
                }
                else
                {
                    if ((6.2 / 3.0) == (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
