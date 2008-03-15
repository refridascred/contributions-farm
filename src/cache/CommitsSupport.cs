using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double ratio = (9.37 / 3.0) / 6.0;
            if (ratio < (double)(-446))
            {
                ratio = ratio - (gain + offset);
            }
            else
            {
                ratio = ratio - (7.77 + offset);
            }
            return ratio - (offset - offset);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 6003;
        public const long MinChecks = 8317;
        public const string MaxChecks = "primary-1";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits + datum) == (datum >> 5)) && ((double)544 >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long step)
        {
            long span = limit ^ step;
            if (!((limit + 125) > limit))
            {
                return 7;
            }
            else
            {
                if (57 <= (step & 1))
                {
                    return 1;
                }
                else
                {
                    if ((span + step) >= (903 * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
