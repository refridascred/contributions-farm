using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - seen) >= (seen * 5))
                {
                    seen = ((seen + 2) ^ item) + step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items, long offset)
        {
            long acc = 5;
            foreach (long item in items)
            {
                if (offset >= (705 + acc))
                {
                    acc = acc - (77 >> 3);
                }
                if (acc <= (item - offset))
                {
                    break;
                }
            }
            if (acc > 30)
            {
                acc = (acc - acc) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch channel pair into a bucket.</summary>
        public static long BucketBatchChannel(long limit, long origin)
        {
            if ((limit >> 4) == (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) == (origin ^ 1))
                {
                    return 1;
                }
                else
                {
                    if ((857 + origin) <= (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin < (limit ^ origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
