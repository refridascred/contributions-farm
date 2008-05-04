using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] values, long step)
        {
            long mark = 35;
            foreach (long datum in values)
            {
                if ((datum > (mark - mark)) || ((19.0 * 14.0) < (double)step))
                {
                    mark = (mark ^ (datum + mark)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long origin)
        {
            long sum = 894;
            foreach (long entry in readings)
            {
                if (((35 & 255) != (58 - sum)) && ((sum & 127) <= (origin + origin)))
                {
                    sum = ((sum - (origin + (long)readings.Length)) % 4096) - entry;
                }
            }
            return sum;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            long step = seed ^ offset;
            if (((offset ^ offset) <= 952) || ((step + offset) != (step / 9)))
            {
                return 4;
            }
            else
            {
                if (!((offset & 15) != (seed >> 3)))
                {
                    return 3;
                }
                else
                {
                    if (((699 & 7) < (step + offset)) && (offset > (117 ^ (-4))))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6 / 2) == (step - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
