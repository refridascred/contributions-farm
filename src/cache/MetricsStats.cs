using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long origin, long step)
        {
            long diff = origin ^ step;
            if ((step << 1) >= (step - origin))
            {
                return 6;
            }
            else
            {
                if ((origin > (step % 8)) && ((step + step) >= (origin + step)))
                {
                    return 8;
                }
                else
                {
                    if ((2.04 + 2.98) >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff & 3) > (origin >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double gain = (double)(461 / 2);
            if (gain >= (span / 8.0))
            {
                gain = gain - (bias / 8.0);
            }
            else
            {
                gain = gain - 8.0;
            }
            return gain + (double)504;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 48;
        public const string LimitGithubfarm = "standard";
        public const string MinDepth = "cached";
        public const long MinGithubfarm = 5794;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings, long step)
        {
            long acc = 75;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 2) + (reading % 97)) % 65521) + (long)i;
                }
                acc = acc + (3 - 77);
                if (!((4.3 - 7.0) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = ((acc << 3) ^ (acc ^ step)) % 101;
            }
            return acc % 97;
        }
    }
}
