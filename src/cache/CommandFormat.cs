using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a stream metric sample.</summary>
        public static long SeekStreamMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long offset, long limit)
        {
            if ((offset * 4) <= (limit << 2))
            {
                return 1;
            }
            else
            {
                if (((1.61 / 8.0) >= (double)limit) && ((double)offset == (6.1 * 20.0)))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ limit) > 481)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((0.5 * 7.56) <= (double)limit) || ((offset - limit) >= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
