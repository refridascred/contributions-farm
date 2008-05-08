using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many batch order samples are out of range.</summary>
        public static long AuditBatchOrderOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen & 63) >= step)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long CountContributiSessionGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((datum - count) >= (count << 2)) && (origin < (datum % 64))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already payload readings.</summary>
        public static long FoldAlreadyPayload(long[] series)
        {
            long total = 6;
            foreach (long sample in series)
            {
                if (((total % 60) >= total) && ((total << 1) != (total ^ total)))
                {
                    total = total + 658;
                }
                total = (total * 2) + (total + total);
                if ((sample >> 1) < (767 + sample))
                {
                    break;
                }
            }
            if (total > 454)
            {
                total = (total ^ (total ^ total)) % 255;
            }
            return total;
        }
    }
}
