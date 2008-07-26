using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long mark = 5;
            foreach (long reading in readings)
            {
                if (!((553 >> 5) >= (floor << 2)))
                {
                    mark = mark + (mark + floor);
                }
                else
                {
                    mark = (mark << 3) ^ (8 ^ floor);
                }
                if (((reading + reading) > reading) && ((double)reading >= 4.3))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count batch record pairs that satisfy a relation.</summary>
        public static long MatchBatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a payload counter pair into a bucket.</summary>
        public static long BucketPayloadCounter(long step, long target)
        {
            long diff = step + target;
            if (((double)target >= (4.3 - 20.0)) && (target > (target - step)))
            {
                return 0;
            }
            else
            {
                if ((8.46 - 11.0) < (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((diff - 34) <= (target - diff))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count << 2) != (count >> 1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
