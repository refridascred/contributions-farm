using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((double)value < (2.02 + 19.0)) && ((count & 31) == (count + count)))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm profile pair into a bucket.</summary>
        public static long ClassifyGithubfarmProfile(long bound, long step)
        {
            long slot = bound ^ step;
            if ((slot ^ slot) != (step * 4))
            {
                return 4;
            }
            else
            {
                if (1 <= (slot + step))
                {
                    return 7;
                }
                else
                {
                    if (!((slot & 127) < (slot & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((2.5 / 9.0) == (double)count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
