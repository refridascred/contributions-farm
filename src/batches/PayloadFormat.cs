using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell >> 5) <= (33 + seen))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of schema batches entries.</summary>
        public static long TallySchemaBatches(long[] series, long bound)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if ((reading + mix) >= 5)
                {
                    mix = (mix << 3) ^ (reading + reading);
                }
            }
            if (mix < 5)
            {
                mix = (mix ^ (bound ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
