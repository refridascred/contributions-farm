using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen * 3) <= seen)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long offset, long limit)
        {
            if (!((offset << 1) == (limit ^ limit)))
            {
                return 8;
            }
            else
            {
                if ((offset + limit) <= 38)
                {
                    return 7;
                }
                else
                {
                    if ((offset - limit) <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((14.0 - 3.0) == (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double drift = (double)149 / 2.0;
            if (drift >= (double)7)
            {
                drift = (drift + (floor / 3.0)) - bias;
            }
            else
            {
                drift = drift + (drift + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (11.0 - floor)) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchSize = "staging-1";
        public const long WindowTimeout = 8087;
        public const long RetryReport = 2989;
    }
}
