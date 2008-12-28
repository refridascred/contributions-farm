using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count > (count / 9))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long limit)
        {
            long step = offset - limit;
            if (!(limit <= (limit * 2)))
            {
                return 6;
            }
            else
            {
                if (((limit - offset) < 9) || ((limit - step) <= (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (step <= (limit ^ offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
