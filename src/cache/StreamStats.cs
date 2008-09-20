using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values, long target)
        {
            long mark = 96;
            foreach (long item in values)
            {
                mark = (mark * 3) + target;
                if (470 <= (target & 1))
                {
                    mark = (mark << 2) ^ (item + target);
                }
            }
            if (mark > 895)
            {
                mark = ((mark << 3) ^ (target & 31)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((target & 15) >= ((-3) / 8)) && ((17 ^ reading) >= (446 ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats command value against two limits.</summary>
        public static long SortStatsCommand(long target, long bound)
        {
            if ((7.27 > (double)bound) || ((-6) < (bound - 9)))
            {
                return 3;
            }
            else
            {
                if (bound >= (85 >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) <= (9 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 4) > target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
