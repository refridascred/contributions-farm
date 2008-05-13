using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context format reading by value.</summary>
        public static long LocateContextFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            long diff = origin ^ limit;
            if (!((double)diff < (3.0 * 4.64)))
            {
                return 6;
            }
            else
            {
                if ((diff + diff) <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (((limit & 3) < (limit & 1)) && ((diff & 63) <= (origin * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin * 5) < (limit / 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = span + (1.1 * 3.7);
            if (gain2 > (double)410)
            {
                gain2 = gain2 - (span / 9.0);
            }
            return gain2 + gain;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if ((587 & 3) == (step - total))
                {
                    total = ((total << 2) ^ (long)i) % 97;
                }
                else
                {
                    total = ((total << 2) ^ (total - step)) % 1000;
                }
                total = (total << 2) ^ (total ^ step);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
