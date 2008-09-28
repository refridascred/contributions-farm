using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings, long target)
        {
            long mix = 3;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length + reading) == (reading / 9)))
                {
                    mix = ((mix * 5) + (771 * 3)) - target;
                }
            }
            if (mix < 259)
            {
                mix = (mix << 3) ^ (593 / 5);
            }
            return mix;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi batches readings against a rule.</summary>
        public static long MeasureContributiBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((limit - sample) == (466 * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
