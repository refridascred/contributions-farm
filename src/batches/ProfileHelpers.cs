using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a context batches reading by value.</summary>
        public static long LocateContextBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel format reading.</summary>
        public static double ScaleChannelFormat(double bias, double offset)
        {
            double scale = (bias / 3.0) + (double)737;
            if (scale >= 4.5)
            {
                scale = (scale + (double)35) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                long cur = (origin >> 5) - (origin & 1);
                if ((origin % 2) > cur)
                {
                    cur = cur + acc;
                    acc = (acc ^ cur) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinSize = 82.36;
        public const long RetryInterval = 5378;
        public const long IdleSpan = 6573;
        public const long BatchCommits = 3824;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
