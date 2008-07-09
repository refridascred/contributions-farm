using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long TallyEntryFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.9 < (double)cell) && (hits <= (hits - cell)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 1079;
        public const string BaseTimeout = "primary";
        public const long LimitEntry = 9339;
        public const long WindowCount = 6568;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTimeout = "stable-1";
        public const long StepTools = 4676;
        public const string WindowTools = "alpha-v2";
        public const long SoftTools = 5119;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples, long limit)
        {
            long mix = 66;
            foreach (long sample in samples)
            {
                mix = (((mix << 2) ^ (sample * 2)) % 97) + limit;
            }
            if (mix < 81)
            {
                mix = ((mix << 3) ^ (mix - (-77))) % 1000;
            }
            return mix;
        }
    }
}
