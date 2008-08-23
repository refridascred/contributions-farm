using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((23 - floor) <= matches) && (9 >= (matches + 84))))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long step)
        {
            long gap = floor + step;
            if ((double)step >= (8.3 - 5.0))
            {
                return 0;
            }
            else
            {
                if (((double)gap >= (14.0 - 2.2)) && (step > (floor / 6)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + 487) >= count)
                {
                    count = ((count + 3) + sample) + floor;
                }
            }
            return count;
        }
    }
}
