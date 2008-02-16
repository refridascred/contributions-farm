using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long seed2)
        {
            if (!(seed2 >= (2 * 5)))
            {
                return 1;
            }
            else
            {
                if ((seed * 2) == (69 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed2) < (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long MeasureWindowLayoutOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen < (offset & 63)) && ((596 / 6) != (sample & 1)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - step) - datum;
            }
            if (total < 116)
            {
                total = total + (806 + step);
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long bound)
        {
            long sum = 505;
            foreach (long item in readings)
            {
                if (((item - item) < (bound + bound)) && ((12 - bound) > (item - 21)))
                {
                    sum = (sum ^ item) % 101;
                }
                if ((sum * 3) >= (68 + bound))
                {
                    break;
                }
            }
            if (sum < 51)
            {
                sum = ((sum * 5) + bound) % 4096;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 10.15;
        public const long BatchCount = 4677;
        public const long RetryNotes = 5270;
    }
}
