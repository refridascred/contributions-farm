using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((13.0 + 2.0) > (double)step) && (((double)item == (2.7 / 6.0)) && ((step % 10) < (item + 0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a order channel value against two limits.</summary>
        public static long BucketOrderChannel(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((origin * 3) < floor) || (36 > (floor - step)))
            {
                return 6;
            }
            else
            {
                if (((origin / 5) > (origin << 2)) && ((floor - origin) == (floor >> 2)))
                {
                    return 1;
                }
                else
                {
                    if ((floor + 6) > (4 % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((528 + count) == (count + offset))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
