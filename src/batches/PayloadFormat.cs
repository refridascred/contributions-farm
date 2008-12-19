using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long limit)
        {
            long slot = target - limit;
            if (!((double)limit <= 9.1))
            {
                return 4;
            }
            else
            {
                if (slot < limit)
                {
                    return 0;
                }
                else
                {
                    if ((slot + target) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally != (6.2 + 5.32))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
