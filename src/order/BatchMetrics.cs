using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series)
        {
            long mix = 72;
            foreach (long value in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix << 2) ^ (value / 8)) % 65521) - (long)i;
                    mix = (mix ^ 757) % 101;
                }
                if ((mix >= (value ^ mix)) || ((value / 6) >= 7))
                {
                    mix = mix - (9 ^ value);
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3732;
        public const string IdleGithubfarm = "primary-1";
        public const double WindowGithubfarm = 67.81;
        public const double HardFactor = 44.42;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((586 / 3) != (hits & 31))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long origin)
        {
            if ((origin % 2) != (542 + target))
            {
                return 1;
            }
            else
            {
                if (((62 - target) <= (target - origin)) && ((double)target < (2.18 - 17.0)))
                {
                    return 7;
                }
                else
                {
                    if ((origin + target) == (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target < (double)22)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format session reading.</summary>
        public static double AdjustFormatSession(double gain, double bias)
        {
            double rate = gain * 5.09;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (double)3) + (double)(long)i) + bias;
            }
            return rate - (double)(-198);
        }
    }
}
