using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long sum = 64;
            foreach (long datum in readings)
            {
                if ((sum < (datum & 255)) && (datum >= ((long)readings.Length / 6)))
                {
                    sum = ((sum << 3) ^ (sum / 2)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            long diff = seed - limit;
            if (!((diff ^ diff) <= (diff & 3)))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) > (97 + limit)) || ((seed >> 5) > (limit & 7)))
                {
                    return 7;
                }
                else
                {
                    if ((diff - limit) == (limit - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.59 / 6.0) != (double)limit)
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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = total ^ (total / 4);
                total = (total ^ (8 + (long)i)) % 4096;
                if ((limit << 2) < total)
                {
                    total = ((total << 2) ^ (limit - total)) % 255;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
