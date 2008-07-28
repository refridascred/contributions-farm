using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long limit)
        {
            long cur = step ^ limit;
            if ((cur + cur) > cur)
            {
                return 4;
            }
            else
            {
                if ((0 - limit) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((cur - step) != (step * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 & 63) != (step << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a entry batch reading.</summary>
        public static double ProjectEntryBatch(double scale, double bias)
        {
            double mean = bias;
            if (mean < (double)163)
            {
                mean = (mean - mean) + scale;
            }
            else
            {
                mean = mean - (double)534;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 3.9) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long acc = 380;
            foreach (long value in readings)
            {
                acc = acc - (value + acc);
            }
            if (acc < 706)
            {
                acc = (acc + (acc % 12)) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double scale = span - (double)96;
            if (scale >= (double)644)
            {
                scale = (scale + scale) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 6.0;
        }
    }
}
