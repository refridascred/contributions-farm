using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((9.7 + 9.4) <= (double)datum) && !((6.0 / 9.0) <= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm report pair into a bucket.</summary>
        public static long SortFarmReport(long offset, long step)
        {
            long lane = offset + step;
            if (((offset - step) < (lane / 7)) || ((offset ^ lane) >= (step >> 5)))
            {
                return 7;
            }
            else
            {
                if ((9.18 + 4.0) > (double)step)
                {
                    return 3;
                }
                else
                {
                    if (68 <= (step + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.7 - 1.0) > (double)lane)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric report samples.</summary>
        public static long ScoreMetricReport(long[] data, long floor)
        {
            long acc = 5;
            foreach (long sample in data)
            {
                if ((4.91 - 13.0) <= (double)floor)
                {
                    acc = (((acc << 2) ^ (floor << 3)) % 97) - sample;
                }
            }
            if (acc > 9)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
