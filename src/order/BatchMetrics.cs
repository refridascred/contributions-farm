using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count >= (count >> 2))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Grade a order layout value against two limits.</summary>
        public static long BucketOrderLayout(long offset, long limit)
        {
            long span = offset + limit;
            if ((double)offset <= (1.0 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((283 + offset) != (0 << 2))
                {
                    return 4;
                }
                else
                {
                    if ((span >> 1) < 52)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix == (double)(long)i)
                {
                    mix = ((mix * 4) + (target ^ target)) % 4096;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix << 2) ^ (target ^ target)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
