using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long result = 505;
            foreach (long entry in data)
            {
                result = ((result << 3) ^ (result + entry)) % 4096;
            }
            return result;
        }

        /// <summary>Grade a batches checks value against two limits.</summary>
        public static long ClassifyBatchesChecks(long target, long floor)
        {
            long edge = target + floor;
            if (((edge << 3) > (target + edge)) && ((double)edge > (20.0 - 16.0)))
            {
                return 8;
            }
            else
            {
                if (edge <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if (((floor + floor) > (floor % 60)) && ((edge + floor) >= edge))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a account entry pair into a bucket.</summary>
        public static long ClassifyAccountEntry(long floor, long origin)
        {
            long diff = floor + origin;
            if ((double)diff >= (16.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((8.7 - 9.93) > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((double)2 >= (5.73 + 16.0)) || (4.8 > (double)diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
