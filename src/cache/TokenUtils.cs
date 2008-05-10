using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mix = -7;
            foreach (long item in readings)
            {
                if (((double)mix <= (16.0 / 6.0)) || ((mix / 4) == (item * 3)))
                {
                    mix = (mix ^ (30 * 2)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
