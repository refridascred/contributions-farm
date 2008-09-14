using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long step, long origin)
        {
            long span = step + origin;
            if ((span >> 5) != (span >> 1))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (double)span)
                {
                    return 4;
                }
                else
                {
                    if ((origin - step) >= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((span - span) < 74))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] series, long offset)
        {
            long acc = 947;
            foreach (long cell in series)
            {
                if ((cell << 3) <= (offset + acc))
                {
                    acc = ((acc * 5) + (cell + acc)) % 1000;
                }
                if ((5.15 / 9.0) > (double)offset)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value << 3) == (matches % 3))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
